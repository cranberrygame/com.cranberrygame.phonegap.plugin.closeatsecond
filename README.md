Cordova ExitAppAtSecond plugin
====================
# Overview #
Exit app at second on android and wp8.

[android, wp8] [cordova cli] [xdk]

This is open source cordova plugin.

You can see Plugins For Cordova in one page: http://cranberrygame.github.io?referrer=github

# Change log #
```c
```
# Install plugin #

## Cordova cli ##
```c
cordova plugin add com.cranberrygame.cordova.plugin.exitappatsecond
```

## Xdk ##
```c
XDK PORJECTS - your_xdk_project - CORDOVA 3.X HYBRID MOBILE APP SETTINGS - PLUGINS AND PERMISSIONS - Third Party Plugins - Add a Third Party Plugin - Get Plugin from the Web -

Name: revmob
Plugin ID: com.cranberrygame.cordova.plugin.exitappatsecond
[v] Plugin is located in the Apache Cordova Plugins Registry
```

## Phonegap build service (config.xml) ##
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

[![](http://img.youtube.com/vi/ublL50r5PW4/0.jpg)](https://www.youtube.com/watch?v=ublL50r5PW4&feature=youtu.be "Youtube")

You can also run following test apk.
https://dl.dropboxusercontent.com/u/186681453/pluginsforcordova/exitappatsecond/apk.html

# Useful links #

Plugins For Cordova<br>
http://cranberrygame.github.io?referrer=github

# Credits #
