using System;
using Gtk;
using System.Collections.Generic;
using GLib;
using Newtonsoft.Json;
using System.Net;
using System.IO;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public class Post
	{
		public int no { get; set; }
		public string now { get; set; }
		public string name { get; set; }
		public string com { get; set; }
		public string filename { get; set; }
		public string ext { get; set; }
		public int w { get; set; }
		public int h { get; set; }
		public int tn_w { get; set; }
		public int tn_h { get; set; }
		public object tim { get; set; }
		public int time { get; set; }
		public string md5 { get; set; }
		public int fsize { get; set; }
		public int resto { get; set; }
		public int bumplimit { get; set; }
		public int imagelimit { get; set; }
		public string semantic_url { get; set; }
		public int replies { get; set; }
		public int images { get; set; }
		public int unique_ips { get; set; }
	}

	public class RootObject
	{
		public List<Post> posts { get; set; }
	}

	protected void OnButtonSubmitClicked (object sender, EventArgs e)
	{
		//A counter that will be used to count the amount of images downloaded
		int counter = 0;

		//Remove unnecessary parts of the URL. An example of a mootUrl: "/g/thread/48910632"
		string mootUrl = entryUrl.Text.Replace("http://", "").Replace("https://", "").Replace("boards.4chan.org", "");

		//Get the thread's number. Example: "48910632"
		//HOW TO ADD MORE BOARDS: Add the following line to the end of this string: '.Replace("<BOARD NAME>", "")'
		string threadNum = mootUrl.Replace ("thread", "").Replace ("/", "").Replace("b", "").Replace("g", "").Replace("int", "");

		//Get the board name. Example: "g"
		string threadBoard = mootUrl.Replace("thread/" + threadNum, "").Replace("/", "");

		//Download the thread's JSON string
		var jsonUrl = new WebClient ().DownloadString ("https://a.4cdn.org" + mootUrl + ".json");

		//Use JSON.Net to deserialize the JSON string
		var jsonRes = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(jsonUrl);

		//Save the userselected path to a string
		string fileDest = filechooserbutton.Filename.ToString();

		//A for loop that will loop through the entire thread
		for(int i = 0; jsonRes.posts.Count > i; i++) {
			
			//If the post has an image, do these things. Skip if no image could be found.
			if(jsonRes.posts[i].tim != null) {
				
				//Get the image's filename
				string filename = jsonRes.posts[i].tim + jsonRes.posts[i].ext;

				//Get the URL of the image
				string filenameURL = "https://i.4cdn.org/" + threadBoard + "/" + filename;

				//Download image and save it to userselected path
				var imgDownload = new WebClient ();
				imgDownload.DownloadFile (filenameURL, fileDest + "/" + filename);

				//Increment the counter by one.
				counter += 1;
			}
		}

		//Display this when all the images have been downloaded
		labelResult.Text = "Saved " + counter.ToString() + " images to " + fileDest;
	}
}
