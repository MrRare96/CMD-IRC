# CMD-IRC

C-IRC is a really simple C# IRC client created for practice reasons with the following functions:

  - Runs in CMD
  - You can connect to an IRC server(yeah)
  - It's small (13 Kb)
  - IT SUPPORTS DCC (don't ask me how) :)
  - It's not efficient at all, 20% cpu usage while downloading a file, on an i7 4710HQ...
  - It likes your memory... 150 MB in use... why? I don't know...

But be warned, DCC is not safe, since its automaticly on auto-accept. Also I did not do much on error handling, so any weird stuff like not being on a known channel might crash te client :).

### Usage

You can use this as a library for C# if you want, although I have no idea how you would do that(I am like a gigantic NOOB in programming).I guess change the namespace or something :). Actually using it as a program is quit simple: on launch you can specify the IRC server using it's IP address(!), you can specify the port of the server, you can specify your nickname, and you can not yet specify a password, furthermore you can join a channel... simple :).

It also has default values, which are:

 - IRC Server: irc.rizon.net (54.229.0.87)
 - IRC Port: 6667
 - Username: CMD-IRCclient
 - Channel: #CMD-IRC

### Version
v0.0.1

### Future Plans
Not much, maybe some error handling, since it can crash when something unexpected comes along. I might add an option to disable auto dcc get. I created this for another application that I am currently developing in my free time. 

### License
I am to lazy to look up the license stuff, but you can use this however you like. Its free for ever, you can modify it, use it, delete it(don't ;) ) etc... I would like some credit, but it's not necesary.


