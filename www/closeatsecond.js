
module.exports = {
   
    closeAtSecond : function () {
		var self = this;
		Cordova.exec(
			function (result) {
				if (result == "onCloseAtSecond") {
					if (self.onCloseAtSecond)
						self.onCloseAtSecond();
				}
			},
            function (error) {
			},
			"CloseAtSecond",
			"closeAtSecond",
			[]
		);//success,fail,class,method,params
    },
    closeRightNow : function () {
		var self = this;	
		Cordova.exec(
			function (result) {
				if (result == "onCloseRightNow") {
					if (self.onCloseRightNow)
						self.onCloseRightNow();
				}
			},
            function (error) {
			},
			"CloseAtSecond",
			"closeRightNow",
			[]
		);//success,fail,class,method,params
    },	
	onCloseAtSecond: null,
	onCloseRightNow: null
};
