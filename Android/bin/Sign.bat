jarsigner -verbose -keystore ../../LeoStudio.keystore -signedjar temp.apk ForexWiz.apk leostudio.keystore
C:\android-sdk-windows\tools\zipalign -v 4 temp.apk ForexWiz_Sign.apk
del temp.apk