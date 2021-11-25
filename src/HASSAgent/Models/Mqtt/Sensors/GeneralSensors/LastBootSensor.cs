﻿using System;
using System.Runtime.InteropServices;

namespace HASSAgent.Models.Mqtt.Sensors.GeneralSensors
{
    public class LastBootSensor : AbstractSensor
    {
        public LastBootSensor(int? updateInterval = 10, string name = "LastBoot", Guid id = default) : base(name ?? "LastBoot", updateInterval ?? 10, id) {}

        public override DiscoveryConfigModel GetAutoDiscoveryConfig()
        {
            return AutoDiscoveryConfigModel ?? SetAutoDiscoveryConfigModel(new SensorDiscoveryConfigModel()
            {
                Name = Name,
                Unique_id = Id.ToString(),
                Device = Variables.DeviceConfig,
                State_topic = $"homeassistant/{Domain}/{Variables.DeviceConfig.Name}/{ObjectId}/state",
                Icon = "mdi:clock-time-three-outline",
                Availability_topic = $"homeassistant/{Domain}/{Variables.DeviceConfig.Name}/availability",
                Device_class = "timestamp"
            });
        }

        public override string GetState()
        {
            return (DateTime.Now - TimeSpan.FromMilliseconds(GetTickCount64())).ToString("s");
        }

        [DllImport("kernel32")]
        private static extern ulong GetTickCount64();
    }
}