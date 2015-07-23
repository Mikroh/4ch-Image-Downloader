# 4ch Image Downloader
This documentation is meant for any unfortunate soul who stumbles upon this project. This application allows you to automatically download images from 4chan threads. I developed this application for myself, so the only boards that work are /b/, /g/, and /int/. If you want to add more boards, see:
<ul>
  <li>line 61 in <em>4chImageDownloader(MONO)/MainWindow.cs</em></li>
  <li>Line 63 in <em>4chImageDownloader(VS)/Form1.cs</em>
</ul>

Binaries can be found in the <em>Binaries</em> directory. The Linux version needs <em>Mono</em> and <em>Gtk#</em> to run. The Windows version <em>should</em> just work. I have no idea if this is actually the case, though.

Direct downloads:
<ul>
  <li><a href="https://drive.google.com/file/d/0B8sLdDVOq1H0UUw3Z3FIbHFvek0/view?usp=sharing">Windows</a></li>
  <li><a href="https://drive.google.com/file/d/0B8sLdDVOq1H0aFdKMUt6b1JUS3c/view?usp=sharing">Linux</a></li>
</ul>

One <strong>really</strong> important thing to note, is that the application will be unresponsive while it is downloading images. It will appear to have crashed, but it hasn't. Just give it time.

The application works, but it's certainly not polished. Therefore, I recommend that you find some other 4chan image downloader if you are looking for one to use.

This application is licensed under <em>The Unlicense</em>. This means that you can do whatever the hell you want with my code. See <em>LICENSE</em> for more details.

This application uses Json.NET by James Newton-King. Json.NET is licensed under the <a href="https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md">MIT License</a>, so keep that in mind if you plan to use Json.NET yourself.
