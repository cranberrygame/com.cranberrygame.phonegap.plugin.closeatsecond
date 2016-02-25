Cordova ExitAppAtSecond plugin
====================
# Overview #
Exit app at second on android and wp8.

[android, wp8] [cordova cli] [xdk] [phonegap build service]

This is open source cordova plugin.

You can see Cordova Plugins in one page: http://cranberrygame.github.io?referrer=github

# Change log #
```c
```
# Install plugin #

## Cordova cli ##
https://cordova.apache.org/docs/en/edge/guide_cli_index.md.html#The%20Command-Line%20Interface - npm install -g cordova@6.0.0
```c
cordova plugin add com.cranberrygame.cordova.plugin.exitappatsecond
```

## Xdk ##
https://software.intel.com/en-us/intel-xdk - Download XDK - XDK PORJECTS - [specific project] - CORDOVA HYBRID MOBILE APP SETTINGS - Plugin Management - Add Plugins to this Project - Third Party Plugins -
```c
Plugin Source: Cordova plugin registry
Plugin ID: cordova-plugin-exitappatsecond

## Cocoon ##
https://cocoon.io - Create project - [specific project] - Setting - Plugins - Search - cranberrygame - exitappatsecond

## Phonegap build service (config.xml) ##
https://build.phonegap.com/ - Apps - [specific project] - Update code - Zip file including config.xml
```c
<gap:plugin name="com.cranberrygame.cordova.plugin.exitappatsecond" source="plugins.cordova.io" />
```

## Construct2 ##

# Server setting #
```c
```

# API #
```javascript


document.addEventListener("deviceready", function(){
	
	//
	window.exitappatsecond.onExitAppAtSecond = function() {
		alert('onExitAppAtSecond');
	};
}, false);
</script>

window.exitappatsecond.exitAppAtSecond();
```
# Examples #
<a href="https://github.com/cranberrygame/cordova-plugin-exitappatsecond/blob/master/example/basic/index.html">example/basic/index.html</a><br>

# Test #

[![](http://img.youtube.com/vi/bMdgsde56ZA/0.jpg)](https://www.youtube.com/watch?v=bMdgsde56ZA&feature=youtu.be "Youtube")

You can also run following test apk.
https://dl.dropboxusercontent.com/u/186681453/pluginsforcordova/exitappatsecond/apk.html

# Useful links #

Cordova Plugins<br>
http://cranberrygame.github.io?referrer=github

# Credits #
