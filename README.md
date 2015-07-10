# 4ch Image Downloader
This documentation is meant for any unfortunate soul who stumbles upon this project. This application allows you to automatically download images from 4chan threads. I developed this application for myself, so the only boards that work are /b/, /g/, and /int/. If you want to add more boards, see line 61 on <em>MainWindow.cs</em>.

I <em>might</em> include some Windows binaries in the future. Until then, you'll have to compile the application yourself using Mono.

Linux binaries can be found in the <em>Bin</em> folder. They require <em>Mono</em> and <em>Gtk#</em> to run. Use these at your own risk.

One <strong>really</strong> important thing to note, is that the application will be unresponsive while it is downloading images. It will appear to have crashed, but it hasn't. Just give it time.

The application works, but it's certainly not polished. Therefore, I recommend that you find some other 4chan image downloader if you are looking for one to use.

This application is licensed under <em>The Unlicense</em>. This means that you can do whatever the hell you want with my code. See <em>LICENSE</em> for more details.

This application uses Json.NET, Copyright (c) 2007 James Newton-King. Json.NET is licensed under the <a href="https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md">MIT License</a>, so keep that in mind if you plan to use Json.NET yourself.
