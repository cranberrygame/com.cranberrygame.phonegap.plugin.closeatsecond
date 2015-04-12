//Copyright (c) 2014 Sang Ki Kwon (Cranberrygame)
//Email: cranberrygame@yahoo.com
//Homepage: http://www.github.com/cranberrygame
//License: MIT (http://opensource.org/licenses/MIT)
package com.cranberrygame.phonegap.plugin;

import org.apache.cordova.CordovaPlugin;
import org.apache.cordova.PluginResult;
import org.apache.cordova.CallbackContext;
import org.json.JSONArray;
import org.json.JSONObject;
import org.json.JSONException;
import org.apache.cordova.CordovaInterface;
import org.apache.cordova.CordovaWebView;
import android.app.Activity;
import android.util.Log;
//
//back key exit method1
import android.app.AlertDialog;
import android.content.DialogInterface;
//back key exit method2: back key twice
import android.widget.Toast;//

public class CloseAtSecond extends CordovaPlugin {
	//back key exit method2: back key twice
	private long lastPressedTime;
	private static final int PERIOD = 2000;

	@Override
	public boolean execute(String action, JSONArray args,CallbackContext callbackContext) throws JSONException {
		PluginResult result = null;
		
		//args.length()
		//args.getString(0)
		//args.getString(1)
		//args.Int(0)
		//args.Int(1)
		//args.getBoolean(0)
		//args.getBoolean(1)

		if (action.equals("closeAtSecond")) {
			//Activity activity=cordova.getActivity();
			//webView			
			//String adUnit = args.getString(0);				
			//Log.d("___PLUGIN_NAME___", adUnit);
			
/*	
			//back key exit method1
			new AlertDialog.Builder(cordova.getActivity())
			.setTitle("Exit")
			.setMessage("Do you want to exit?")
			.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
			  
			  @Override
			  public void onClick(DialogInterface dialog, int which) {
				android.os.Process.killProcess(android.os.Process.myPid());
			  }
			})
			.setNegativeButton("No", null)
			.setCancelable(false)
			.show();		
*/
			//back key exit method2: back key twice
			//if (event.getDownTime() - lastPressedTime < PERIOD) {
			if (System.currentTimeMillis() - lastPressedTime < PERIOD) {
			
				PluginResult pr = new PluginResult(PluginResult.Status.OK, "onCloseAtSecond");
				//pr.setKeepCallback(true);
				callbackContext.sendPluginResult(pr);
				//PluginResult pr = new PluginResult(PluginResult.Status.ERROR);
				//pr.setKeepCallback(true);
				//callbackContext.sendPluginResult(pr);
				
				android.os.Process.killProcess(android.os.Process.myPid());
			} 
			else {
				Toast.makeText(cordova.getActivity().getApplicationContext(), "press again to exit.",
						Toast.LENGTH_SHORT).show();
				//lastPressedTime = event.getEventTime();
				lastPressedTime = System.currentTimeMillis();
			}	
			
			return true;
		}
		else if (action.equals("closeRightNow")) {
			//Activity activity=cordova.getActivity();
			//webView			
			//String adUnit = args.getString(0);				
			//Log.d("___PLUGIN_NAME___", adUnit);
			
			PluginResult pr = new PluginResult(PluginResult.Status.OK, "onCloseRightNow");
			//pr.setKeepCallback(true);
			callbackContext.sendPluginResult(pr);
			//PluginResult pr = new PluginResult(PluginResult.Status.ERROR);
			//pr.setKeepCallback(true);
			//callbackContext.sendPluginResult(pr);
				
			android.os.Process.killProcess(android.os.Process.myPid());
		}
			
		return false; // Returning false results in a "MethodNotFound" error.				
	}
}