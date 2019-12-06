﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityOSC;
using System.Text;
using System.Threading.Tasks;

public class EnemyStatusServer : MonoBehaviour {
    // Start is called before the first frame update
    #region Network Settings //----------追記
	public string serverName;
	public int inComingPort; //----------追記
	#endregion //----------追記

	private Dictionary<string, ServerLog> servers;

    void Awake() {
        IpGetter ipGetter = new IpGetter();
        string myIP = ipGetter.GetIp();

        if (myIP == HostList.phone1.ip) {
            serverName = HostList.phone2.server_status;
            inComingPort = HostList.phone2.port_status;
        }
        else {
            serverName = HostList.phone1.server_status;
            inComingPort = HostList.phone1.port_status;
        }
        
        // Debug.Log("server IP : " + serverName + "   port : " + inComingPort);

        OSCHandler.Instance.serverInit(serverName,inComingPort); //init OSC　//----------変更
        servers = new Dictionary<string, ServerLog>();
    }

    // Update is called once per frame

    void Update() {
        OSCHandler.Instance.UpdateLogs();
		servers = OSCHandler.Instance.Servers;
    }
    
    void LateUpdate(){
        foreach( KeyValuePair<string, ServerLog> item in servers ){
			// If we have received at least one packet,
			// show the last received from the log in the Debug console
			if(item.Value.log.Count > 0){
				int lastPacketIndex = item.Value.packets.Count - 1;
                Debug.Log("get");

				// UnityEngine.Debug.Log(String.Format("SERVER: {0} ADDRESS: {1} VALUE 0: {2}",
				// 	item.Key, // Server name
				// 	item.Value.packets[lastPacketIndex].Address, // OSC address
				// 	item.Value.packets[lastPacketIndex].Data[0].ToString())); //First data value

                if(item.Value.packets[lastPacketIndex].Address.ToString() == "/position"){
                    Vector3 enemyPosition;
                    float rotY;
                    enemyPosition.x = (float)item.Value.packets[lastPacketIndex].Data[0];
                    enemyPosition.y = (float)item.Value.packets[lastPacketIndex].Data[1];
                    enemyPosition.z = (float)item.Value.packets[lastPacketIndex].Data[2];
                    rotY = (float)item.Value.packets[lastPacketIndex].Data[3];
                    OgreStatus.position = enemyPosition;
				}
			}
		}
        // Debug.Log(Time.deltaTime);
    }
}
