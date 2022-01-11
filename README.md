# QuadControlStation

This is a application written in C# designed to communicate via WiFi with a Quadcopter.
It does this using the socket library, which is just to configure it as a client and connect to the server hosted on a esp8266.
To control the quadcopter You have to connect a gamepad, the analog sticks are mapped to send the pitch, roll, yaw commands as well as the throttle.
In it's current state the application needs to have a gamepad connected otherwise it will not load.
