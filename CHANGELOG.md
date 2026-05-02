
202605

update to .net 10 sdk

updated TargetFramework from net8.0-windows10 to net10.0-windows10



compile error:

无法处理文件 Controls\Onboarding\Onboarding-4-MQTT.resx，因为它位于 Internet 或受限区域中，或者文件上具有 Web 标记。要想处理这些文件，请删除 Web 标记。https://github.com/hass-agent/HASS.Agent 

PowerShell

goto the directory \developer_HASS.Agent

deletes the Web Mark from the file, allowing it to be processed. You can run the following command in PowerShell to unblock all files in the current directory and its subdirectories:

 run the following command:

~~~
Get-ChildItem -Recurse | Unblock-File

~~~

compile ok

