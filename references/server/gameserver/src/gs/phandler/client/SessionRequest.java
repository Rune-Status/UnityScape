package org.moparscape.msc.gs.phandler.client;

import org.apache.mina.common.IoSession;
import org.moparscape.msc.config.Formulae;
import org.moparscape.msc.gs.Instance;
import org.moparscape.msc.gs.builders.RSCPacketBuilder;
import org.moparscape.msc.gs.connection.Packet;
import org.moparscape.msc.gs.model.Player;
import org.moparscape.msc.gs.model.World;
import org.moparscape.msc.gs.phandler.PacketHandler;
import org.moparscape.msc.gs.util.Logger;

public class SessionRequest implements PacketHandler {

	/**
	 * World instance
	 */
	public static final World world = Instance.getWorld();

	public void handlePacket(Packet p, IoSession session) throws Exception {
	System.out.println("SessionRequest");
		Player player = (Player) session.getAttachment();

		if (player.isInitialized()) {
			Logger.println("[WARNING] SessionRequest for already Initialized player!");
			return;
		}
		byte userByte = p.readByte();
			System.out.println("SessionRequest - userbyte="+userByte);
		player.setClassName(p.readString().trim());
		System.out.println("SessionRequest - className="+player.getClassName());
		long serverKey = Formulae.generateSessionKey(userByte);
		player.setServerKey(serverKey);
		RSCPacketBuilder pb = new RSCPacketBuilder();
		pb.setBare(true);
		pb.addLong(serverKey);
		System.out.println("SessionRequest - sessionID="+serverKey);
		session.write(pb.toPacket());
	}
}
