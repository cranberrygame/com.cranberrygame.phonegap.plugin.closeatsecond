using System.Windows;
using System.Runtime.Serialization;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using System.Diagnostics; //Debug.WriteLine
//
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System; //Environment

namespace Cordova.Extension.Commands
{
    public class ExitAppIfTwice : BaseCommand
    {
		//back key exit method2: back key twice
		private long lastPressedTime;
		private int PERIOD = 2000;

        Popup popup;
        
        public void exitAppIfTwice(string args)
        {
            //String adUnit = JsonHelper.Deserialize<string[]>(args)[0];
            //Debug.WriteLine("adUnit: " + adUnit);

			//back key exit method2: back key twice
            if (Environment.TickCount - lastPressedTime < PERIOD)
            {
				
				Application.Current.Terminate();
			} 
			else {
				showToast("press again to exit.");
                lastPressedTime = Environment.TickCount;
			}

			DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "ok"));			
        }

		private void showToast(string message)
        {
			//DispatchCommandResult(new PluginResult(PluginResult.Status.OK));
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                PhoneApplicationFrame frame = Application.Current.RootVisual as PhoneApplicationFrame;
                if (frame != null)
                {
                    PhoneApplicationPage page = frame.Content as PhoneApplicationPage;
                    if (page != null)
                    {
                        Grid grid = page.FindName("LayoutRoot") as Grid;
                        if (grid != null)
                        {
                            TextBlock tb = new TextBlock();
                            tb.TextWrapping = TextWrapping.Wrap;
                            tb.TextAlignment = TextAlignment.Center;
                            tb.Text = message;
                            tb.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); // white

                            Grid pgrid = new Grid();
                            pgrid.HorizontalAlignment = HorizontalAlignment.Stretch;
                            pgrid.VerticalAlignment = VerticalAlignment.Stretch;
                            pgrid.Margin = new Thickness(20);
                            pgrid.Children.Add(tb);
                            pgrid.Width = Application.Current.Host.Content.ActualWidth - 80;

                            Border b = new Border();
                            b.CornerRadius = new CornerRadius(12);
                            b.Background = new SolidColorBrush(Color.FromArgb(190, 55, 55, 55));
                            b.HorizontalAlignment = HorizontalAlignment.Center;
                            b.Child = pgrid;

                            if (popup != null && popup.IsOpen)
                            {
                                popup.IsOpen = false;
                            }
                            popup = new Popup();
                            popup.Child = b;

                            popup.HorizontalOffset = 20;
                            popup.Width = Application.Current.Host.Content.ActualWidth;
                            popup.HorizontalAlignment = HorizontalAlignment.Center;

                            //bottom
                            popup.VerticalAlignment = VerticalAlignment.Bottom;
                            popup.VerticalOffset = -100; // TODO can do better

                            grid.Children.Add(popup);
                            popup.IsOpen = true;

                            hideToast(PERIOD);							
                        }
						
						DispatchCommandResult(new PluginResult(PluginResult.Status.OK));
                    }
                    else
                    {
                        DispatchCommandResult(new PluginResult(PluginResult.Status.INSTANTIATION_EXCEPTION));
                    }
                }
            });
        }

        private async void hideToast(int delay)
        {
            await Task.Delay(delay);
            popup.IsOpen = false;
        }
	}
}