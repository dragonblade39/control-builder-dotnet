// DataController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace
{
    [ApiController]
    [Route("api/data")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            var data = new
            {
                tree = new List<object>
                {
                    new
                    {
                        label = "Root",
                        children = new List<object>
                        {
                            new
                            {
                                label = "C300_262",
                                children = new List<object>
                                {
                                    new
                                    {
                                        label = "CEEC300_155",
                                        children = new List<object>
                                        {
                                            new { label = "SCM_grid" }
                                        }
                                    },
                                    new
                                    {
                                        label = "IOLINK_153",
                                        children = new List<object>
                                        {
                                            new { label = "AO_203" },
                                            new { label = "DI-HV_169" },
                                            new { label = "UIO-2_221" }
                                        }
                                    },
                                    new { label = "IOLINK_154" }
                                },
                                link = "/screen2"
                            },
                            new
                            {
                                label = "C300_sim",
                                children = new List<object>
                                {
                                    new
                                    {
                                        label = "CEEC300_155",
                                        children = new List<object>
                                        {
                                            new { label = "SCM_grid" }
                                        }
                                    },
                                    new
                                    {
                                        label = "IOLINK_153",
                                        children = new List<object>
                                        {
                                            new { label = "AO_203" },
                                            new { label = "DI-HV_169" },
                                            new { label = "UIO-2_221" }
                                        }
                                    },
                                    new { label = "IOLINK_154" }
                                },
                                link = "/screen3"
                            },
                            new
                            {
                                label = "FIM4_299",
                                children = new List<object>
                                {
                                    new { label = "Child1" },
                                    new { label = "Child2" }
                                },
                                link = "/screen4"
                            },
                            new
                            {
                                label = "Unassigned",
                                children = new List<object>
                                {
                                    new { label = "example_c300pm_pidpla" },
                                    new { label = "example_cascade" },
                                    new { label = "example_IORef" },
                                    new { label = "example_motor" },
                                    new { label = "example_pid" },
                                    new { label = "example_pidloop" }
                                },
                                link = "/screen5"
                            }
                        }
                    }
                },

                options = new List<string>
                {
                    "Security Options", "Control and I/O Network", "Server History",
                    "Server Displays", "Control Confirmation", "QVCS",
                    "Identification", "System Time", "Main", "Statistics",
                    "Peer Connections", "Hardware Information", "FTE",
                    "UDP/TCP", "IP/ICMP", "Soft Failures"
                },

                Section1 = new
                {
                    field1 = new List<object>
                    {
                        new { name = "tagName", label = "Tag Name:", type = "text", size = 35 },
                        new { name = "itemName", label = "Item Name #:", type = "text", size = 35 },
                        new { name = "applicationImageVersion", label = "Application Image Version:", type = "text", size = 35 },
                        new
                        {
                            name = "controllerCommand",
                            label = "Controller Command:",
                            type = "select",
                            disabled = true,
                            options = new List<object>
                            {
                                new { value = "NONE", text = "NONE" },
                                new { value = "Option1", text = "Option1" },
                                new { value = "Option2", text = "Option2" }
                            }
                        },
                        new { name = "associatedAsset", label = "Associated Asset #:", type = "text", size = 35 },
                        new
                        {
                            name = "targetPlatform",
                            label = "Target Platform (Model):",
                            type = "select",
                            disabled = true,
                            options = new List<object>
                            {
                                new { value = "NONE", text = "NONE" },
                                new { value = "Option1", text = "Option1" },
                                new { value = "Option2", text = "Option2" }
                            }
                        },
                        new { name = "platformType", label = "Platform Type:" }
                    },
                    field2 = new List<object>
                    {
                        new { label = "Network Address Configuration" },
                        new { name = "deviceIndex", label = "Device Index", type = "text", size = 35 },
                        new { name = "ethernetIpAddress", label = "Ethernet IP Address", value = "10.78.80.51" },
                        new { name = "certificateAuthorityIp", label = "Certificate Authority IP Address" }
                    },
                    field3 = new List<object>
                    {
                        new { label = "Ethernet Protocols Supported" },
                        new { name = "etherNetIP", type = "checkbox", optionLabel = "EtherNet/IP" }
                    },
                    field4 = new List<object>
                    {
                        new { label = "State Information" },
                        new { label = "Controller State", value = "NOTLOADED" },
                        new { label = "Redundancy Role", value = "UNDEFINED" },
                        new { label = "Synchronization State", value = "----" }
                    }
                },

                Section2 = new
                {
                    field1 = new List<object>
                    {
                        new { label = "Enable Extended CC-PCNT02 Feature Configuration", description = "Checking this box indicates that the downloaded controller image will support extended features, such as Experion Profit Control and Ethernet Interface Module" },
                        new { name = "featureConfigurationNumber", label = "Feature Configuration #" },
                        new { name = "enableExtendedFeatureConfig", type = "checkbox", label = "Enable Extended Feature Configuration" },
                        new { label = "Controller Capability:" }
                    },
                    field2 = new List<object>
                    {
                        new { label = "Redundancy Configuration" },
                        new { name = "moduleIsRedundant", type = "checkbox", label = "Module is redundant" },
                        new { name = "secondaryTagName", label = "Secondary Tag Name" }
                    },
                    field3 = new List<object>
                    {
                        new { label = "EtherNet/IP Communication Mode" },
                        new
                        {
                            name = "communicationMode",
                            label = "Communication Mode:",
                            type = "select",
                            disabled = true,
                            options = new List<object>
                            {
                                new { value = "NONE", text = "Direct Connection" },
                                new { value = "Option1", text = "Option1" },
                                new { value = "Option2", text = "Option2" }
                            }
                        },
                        new { type = "button", label = "Reset EIM Associations", disabled = true }
                    },
                    field4 = new List<object>
                    {
                        new { label = "Advanced Configuration" },
                        new { name = "alarmingEnabled", type = "checkbox", label = "Alarming Enabled" },
                        new { name = "disableMemoryRetention", type = "checkbox", label = "Disable Memory Retention and Alerts" },
                        new { name = "temperatureHighAlarm", label = "Temperature High Alarm (degC)", type = "text", size = 33 }
                    }
                }
            };

            return Ok(data);
        }
    }
}