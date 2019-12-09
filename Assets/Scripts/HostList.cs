using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class HostList {
    static public Host phone1 = new Host(
        "192.168.11.58",
        "status",
        "flag",
        "realsense",
        8005,
        8006,
        8002,
        8000
    );
    static public Host phone2 = new Host(
        "192.168.11.59",
        "status",
        "flag",
        "realsense",
        8006,
        8005,
        8002,
        8001
    );
    static public string ip_audience = "192.168.11.60";

    public class Host {
        public string ip {get; set;}
        public string server_status {get; set;}
        public string server_flag {get; set;}
        public string server_realsense {get; set;}
        public int port_status {get; set;}
        public int port_flag {get; set;}
        public int port_realsense {get; set;}
        public int port_audienceserver {get; set;}

        public Host(string _ip, string server1, string server2, string server3, int port1, int port2, int port3, int port4) {
            ip = _ip;
            server_status = server1;
            server_flag = server2;
            server_realsense = server3;
            port_status = port1;
            port_flag = port2;
            port_realsense = port3;
            port_audienceserver = port4;
        }
    }
}