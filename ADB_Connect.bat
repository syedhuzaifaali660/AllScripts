@ECHO OFF
ECHO.
ECHO Make sure the device is connected via USB
ECHO.
PAUSE
adb tcpip 5555
ECHO.
ECHO Please disconnect the device from USB
ECHO.
PAUSE
adb connect 192.168.18.30
PAUSE
ECHO.
ECHO Visit This link for more information https://www.youtube.com/watch?v=Y7FuOsxliug
ECHO Visit Link if adb server not connecting https://www.reddit.com/r/AndroidStudio/comments/cjwnl8/unable_to_connect_my_phone_with_wireless/
ECHO.
PAUSE