# KSYMediaPlayerForXamarinAndroid
项目是将金山云Android播放SDK（KSYUN Live Streaming player SDK）转换为Xamarin的Android Binding工程，具体Api文档请参见https://github.com/ksvc/KSYMediaPlayer_Android。

#工程说明
1、依赖的Jars，生成操作设置为EmbeddedReferenceJar类型：（SDK包中有）
(1)libksyplayer.jar;
(2)libksystat.jar;
*另外需要的Jars，生成操作设置为EmbeddedJar类型：（自己从网络下载）
httpclient.jar、httpcore.jar
2、依赖的so文件，生成操作设置为EmbeddedNativeLibrary,根据需要添加到工程中，可自由删减以减小apk包。
3、依赖dll：（1）Xamarin.Android.Support.v4.dll；（2）Xamarin.Android.Support.v7.AppCompat.dll；
4、Metadata.xml中配置相关的转换：如无配置，在调用时部分类的事件未转换，无法调用。
