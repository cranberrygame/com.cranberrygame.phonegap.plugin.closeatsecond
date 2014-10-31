
module.exports = {
   
    closeAtSecond : function () {		
		Cordova.exec(
			function (result) {
				if (result == "onCloseAtSecond") {
					if (self.onClose)
						self.onClose();
				}
			},
            function (error) {
			},
			"CloseAtSecond",
			"closeAtSecond",
			[]
		);//success,fail,class,method,params
    },
	onCloseAtSecond: null
};
