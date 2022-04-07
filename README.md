
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/LAB02-Research/HASS.Agent)](https://github.com/LAB02-Research/HASS.Agent/releases/)
[![license](https://img.shields.io/badge/license-MIT-blue)](#license)
[![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://www.microsoft.com/ "Go to Microsoft homepage")
[![dotnet](https://img.shields.io/badge/.NET-6.0-blue)](https://img.shields.io/badge/.NET-6.0-blue)
![GitHub all releases](https://img.shields.io/github/downloads/LAB02-Research/HASS.Agent/total?color=blue)
![GitHub latest](https://img.shields.io/github/downloads/LAB02-Research/HASS.Agent/latest/total?color=blue)
[![Discord](https://img.shields.io/badge/dynamic/json?color=blue&label=Discord&logo=discord&logoColor=white&query=presence_count&suffix=%20Online&url=https://discordapp.com/api/guilds/932957721622360074/widget.json)](https://discord.gg/nMvqzwrVBU)

<a href="https://github.com/LAB02-Research/HASS.Agent/">
    <img src="https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/logo_128.png" alt="HASS.Agent logo" title="HASS.Agent" align="right" height="128" /></a>

# HASS.Agent

HASS.Agent is a Windows-based client application for [Home Assistant](https://www.home-assistant.io), developed in .NET 6.

Click [here](https://github.com/LAB02-Research/HASS.Agent/releases/latest/download/HASS.Agent.Installer.exe) to download the latest installer.

----

Agora o HASS.Agent está em português do Brasil para brasileiros e usuários de língua portuguesa!

Clique [aqui](https://github.com/LAB02-Research/HASS.Agent/releases/tag/b2022.4.2) para baixar o instalador mais recente com a tradução! Obrigado [@LeandroIssa](https://github.com/LeandroIssa) :)

----

Developing and maintaining this tool (and everything that surrounds it) takes up a lot of time. It's completely free, and will always stay that way without restrictions. However, like most developers, I run on caffeïne - so a cup of coffee is always very much appreciated! 

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/lab02research)

----

### Contents

 * [Why?](#why)
 * [Functionality](#functionality)
 * [Screenshots](#screenshots)
 * [Installation](#installation)
 * [Help and Documentation](#help-and-documentation)
 * [What it's not](#what-its-not)
 * [Issue Tracker](#issue-tracker)
 * [Helping Out](#helping-out)
 * [Wishlist](#wishlist)
 * [Credits and Licensing](#credits-and-licensing)
 * [Legacy](#legacy)

----

### Why?

The main reason I built this is that I wanted to receive notifications on my PC, including images, and to quickly perform actions (e.g. to toggle a lamp). There weren't any software-based solutions for this, so I set out to build one myself. 

----

### Functionality

Summary of the core functions:

* **Notifications**: receive notifications, show them using Windows builtin toast popups, and optionally attach images. 
  - *This requires the installation of the [HASS.Agent Notifier integration](https://github.com/LAB02-Research/HASS.Agent-Notifier)*.

* **Quick Actions**: use a keyboard shortcut to quickly pull up a command interface, through which you can control Home Assistant entities - or, assign a keyboard shortcut to individual Quick Actions for even faster triggering.

* **Commands**: control your PC (or other Windows based device) through Home Assistant using custom- or built-in commands.

* **Sensors**: send your PC's sensors to Home Assistant to monitor cpu, mem, webcam usage, wmi- and performance counter data, etc.

* **Satellite Service**: use the service to collect sensordata and execute commands, even when you're not logged in. 

* All entities are dynamically acquired from your Home Assistant instance.

* Commands and sensors are automatically added to your Home Assistant instance.

----

### Screenshots

Notification examples:

![Image-based toast notification](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_toast_image.png)  ![Text-based toast notification](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_toast_text.png)

This is the Quick Action window you'll see when using the hotkey. This window automatically resizes to the amount of buttons you've added:

![Quick Actions](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_quickactions.png)

You can easily configure a new Quick Action, HASS.Agent will fetch your entities for you:

![New Quick Actions](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_new_quickaction.png)

The sensors configuration screen:

![Sensors](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_sensors.png)
    
Adding a new sensor is just as easy:

![Sensors](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_new_sensor.png)

Easily manage the satellite service through HASS.Agent:

![Service](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_satellite_service.png)

You'll be guided through the configuration options during onboarding:

![Onboarding Task](https://raw.githubusercontent.com/LAB02-Research/HASS.Agent/main/images/hass_agent_onboarding_startup.png)
    
----

### Installation

Installing HASS.Agent is easy; just [download the latest installer](https://github.com/LAB02-Research/HASS.Agent/releases/latest/download/HASS.Agent.Installer.exe), run it and you're done! The installer is signed and won't download or do weird stuff - it just places everything where it should, and launches with the right parameter. 

After installing, the onboarding process will help you get everything configured, step by step.

[Click here to download the latest installer](https://github.com/LAB02-Research/HASS.Agent/releases/latest/download/HASS.Agent.Installer.exe)

If you want to install manually, there are .zip packages available for every release. Read the [manual](https://github.com/LAB02-Research/HASS.Agent/wiki/1.-Installation#2-manual) for more info.

----

### Help and Documentation

Stuck while installing or using HASS.Agent, need some help integrating the sensors/commands or have a great idea for the next version?

There are a few channels through which you can reach out:

* [Github Tickets](https://github.com/LAB02-Research/HASS.Agent): Report bugs, feature requests, ideas, tips, ..

* [Wiki](https://github.com/LAB02-Research/HASS.Agent/wiki): Installation, configuration and usage documentation, as well as examples.

* [Discord](https://discord.gg/nMvqzwrVBU): Get help with setting up and using HASS.Agent, report bugs or just talk about whatever.

* [Home Assistant forum](https://community.home-assistant.io/t/hass-agent-a-new-windows-based-client-to-receive-notifications-perform-quick-actions-and-much-more/369094): Bit of everything, with the addition that other HA users can help as well.

If you want to help with the development of HASS.Agent, check out the [Helping Out](#helping-out) section for (translating) info.

----

### What it's not

A Linux/macOS client! 

This question comes up a lot, understandably. However it's currently focussed on being a Windows-based client. Even though .NET 6 allows for Linux/macOS development, it's not as easy as pressing a button. The interface would have to be redesigned from the ground up, sensors and commands would need multiple codebases for each OS, testing would take way more time, every OS handles notifications differently, etc.

Since this is a sparetime project, next to a fulltime job, it's just not realistic. I'd love to tinker with it in the future, perhaps as a testcase for Microsoft's new MAUI platform, but it won't happen anytime soon. By focussing on Windows, I can make sure it really excels there instead of being meh everywhere.

You can try this [companion app](https://www.home-assistant.io/blog/2020/09/18/mac-companion/) for macOS, or [IoPC](https://github.com/maksimkurb/IoPC) which runs on Linux. Note: I haven't tested either.

----

### Issue Tracker

To centrally manage all issues (community provided (e.g. via [Discord](https://discord.gg/nMvqzwrVBU)), [GitHub tickets](https://github.com/LAB02-Research/HASS.Agent/issues) and things I come up with), I use JetBrain's YouTrack platform.

There you can see which issues are known (bugs, cosmetics, nice-to-have, etc) and which issues are currently worked on. You can also see some graphs (who doesn't love them) on which part of HASS.Agent has the most tickets, and what type.

It's read-only, please use GitHub to post tickets because that's where users will look first :)

[HASS.Agent YouTrack Dashboard](https://lab02research.youtrack.cloud)

----

### Helping Out

The best way to help out with developing is to test as much as you can, and report any weird or failing behavior by [opening a ticket](https://github.com/LAB02-Research/HASS.Agent/issues). 

Same goes for sharing ideas for new (or improved) functions! If you want, you can [join on Discord](https://discord.gg/nMvqzwrVBU) to discuss your ideas.

Another great way is to help translating HASS.Agent. It's easy thanks to POEditor - no coding knowledge required. For more info, check out the translating wiki page:

[Translating](https://github.com/LAB02-Research/HASS.Agent/wiki/Translating)

You can work on an existing language, or suggest a new one.

----

### Wishlist

A summary of things I want to add somewhere down the road:

 * **Notifications**: add 'critical' type to attract more attention
 * **Notifications**: history window
 * **Notifications**: show a videostream for x seconds with size y (small/normal/fullscreen) on position z (bottom right, center screen, etc)
 * **Notifications**: use websockets so the integration/port reservations/firewall rules aren't needed
 * **Notifications**: broadcast to all HASS.Agents on a subnet
 * **Quick Actions**: show current state in window
 * **Quick Actions**: ability to change button size (small/medium/large)
 * **Quick Actions**: ability to define mdi icons, and/or fetch the entity-specified icon from Home Assistant
 * **Quick Actions**: add pages as tabs instead of one form, i.e. one tab with 'lights', one tab with 'switches'
 * **General**: a built-in way to show a Home Assistant dashboard
 * **General**: internal mDNS client/server to drop the need for IPs

The complete list can be found on the [HASS.Agent YouTrack Dashboard](https://lab02research.youtrack.cloud). If your idea isn't on there, please [create a ticket](https://github.com/LAB02-Research/HASS.Agent/issues) or [discuss on Discord](https://discord.gg/nMvqzwrVBU).

----

### Credits and Licensing

First: thanks to the entire team that's developing [Home Assistant](https://www.home-assistant.io) - such an amazing platform!

Second: I learned a lot from sleevezipper's [HASS Workstation Service](https://github.com/sleevezipper/hass-workstation-service). Thank you for sharing your hard work!

Thanks to [POEditor](https://poeditor.com) for providing a free opensource license for their excellent translation platform!

And a big thank you to all other packages:

[CoreAudio](https://github.com/morphx666/CoreAudio), [HotkeyListener](https://github.com/Willy-Kimura/HotkeyListener), [MQTTnet](https://github.com/chkr1011/MQTTnet), [Syncfusion](https://www.syncfusion.com), [Octokit](https://github.com/octokit/octokit.net), [Cassia](https://www.nuget.org/packages/Cassia.NetStandard/), [Grapevine](https://scottoffen.github.io/grapevine), [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor), [Newtonsoft.Json](https://www.newtonsoft.com/json), [Serilog](https://github.com/serilog/serilog), [CliWrap](https://github.com/Tyrrrz/CliWrap), [HADotNet](https://github.com/qJake/HADotNet), [Microsoft.Toolkit.Uwp.Notifications](https://github.com/CommunityToolkit/WindowsCommunityToolkit), [GrpcDotNetNamedPipes](https://github.com/cyanfish/grpc-dotnet-namedpipes), [gRPC](https://github.com/grpc/grpc), [ByteSize](https://github.com/omar/ByteSize).

Please consult their individual licensing if you plan to use any of their code.

Everything on the HASS.Agent platform is released under the [MIT license](https://opensource.org/licenses/MIT).

---

### Legacy

HASS.Agent is a .NET 6 application. If for some reason you can't install .NET 6, you can use the last .NET Framework 4.8 version:

[v2022.3.8](https://github.com/LAB02-Research/HASS.Agent/releases/tag/v2022.3.8)

It's pretty feature complete if you just want commands, sensors, quickactions and notifications. 

You'll need to have .NET Framework 4.8 installed on your PC, which you can [download here](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer).

If you find any bugs, feel free to [create a ticket](https://github.com/LAB02-Research/HASS.Agent/issues) and I'll try to patch it.
