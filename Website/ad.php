<?php
$adlist=array(
array('data' => '<a href="http://count.chanet.com.cn/click.cgi?a=177380&d=153490&u=&e=" target="_blank"><IMG SRC="http://file.chanet.com.cn/image.cgi?a=177380&d=153490&u=&e=" width="336" height="80"  border="0"></a>',
'height' => 80),
array('data' => '<a href="http://count.chanet.com.cn/click.cgi?a=177380&d=153793&u=&e=" target="_blank"><IMG SRC="http://file.chanet.com.cn/image.cgi?a=177380&d=153793&u=&e=" width="336" height="60"  border="0"></a>',
'height' => 60),
array('data' => '<a href="http://count.chanet.com.cn/click.cgi?a=177380&d=168099&u=&e=" target="_blank"><IMG SRC="http://file.chanet.com.cn/image.cgi?a=177380&d=168099&u=&e=" width="336" height="60"  border="0"></a>',
'height' => 60),
array('data' => '<a href="http://count.chanet.com.cn/click.cgi?a=177380&d=170562&u=&e=" target="_blank"><IMG SRC="http://file.chanet.com.cn/image.cgi?a=177380&d=170562&u=&e=" width="336" height="60"  border="0"></a>',
'height' => 60),
array('data' => '<a href="http://count.chanet.com.cn/click.cgi?a=177380&d=158555&u=&e=" target="_blank"><IMG SRC="http://file.chanet.com.cn/image.cgi?a=177380&d=158555&u=&e=" width="336" height="280"  border="0"></a>',
'height' => 280),
array('data' => '<table cellpadding="0" cellspacing="0" bgcolor="#ecf4fc" style="width:290px;border:0;"><tr><td rowspan="2" align="center"><div style="margin:5px auto; width: 80px;height:80px;"><a target="_blank" href="http://s.click.taobao.com/t_1?i=r7ToPeHlMI49Kw%3D%3D&p=mm_11726372_0_0&n=12" style="width: 80px; margin:0px;padding:0px;height: 80px; overflow:hidden;"><img style="margin:0px;border:none;" src="http://image.taobao.com/bao/uploaded/http://img01.taobaocdn.com/bao/uploaded/i1/T1HCdVXh8fXXbkMfTb_093753.jpg_sum.jpg"></a></div><div class="clearing"></div></td><td colspan="2" ><a target="_blank" href="http://s.click.taobao.com/t_1?i=r7ToPeHlMI49Kw%3D%3D&p=mm_11726372_0_0&n=12" style="height:40px;width:180px;margin:5px;line-height:20px;color:#1E95D4">【酷科电子】酷视 青花瓷 带麦克风摄像头-KS-S910</a></td></tr><tr><td nowrap="nowrap" > <span style="font-weight:600;margin:5px;line-height:30px;color:#CC0000;">45.0元</span>&nbsp;</td><td nowrap="nowrap" width="100px" ><a target="_blank"href="http://s.click.taobao.com/t_1?i=r7ToPeHlMI49Kw%3D%3D&p=mm_11726372_0_0&n=12"><img name="" style="margin:0px; pandding:0px;line-height:24px;vertical-align: text-bottom;border:none;" src="http://img.alimama.cn/images/tbk/cps/fgetccode_btn.gif"></a></td></tr></table>',
'height' => 80)
);

if(isset($_REQUEST['id']))
{
	$i=$_REQUEST['id'];
}else{
	$i=rand(0,count($adlist)-1);
}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title><?php echo $adlist[$i]['height'];?></title>
</head>
<body style="padding:0;margin:0;background:#ecf4fc;font-size:13px;">

<?php echo $adlist[$i]['data'];?>
<script type="text/javascript" src="http://js.tongji.linezing.com/2359240/tongji.js"></script><noscript><a href="http://www.linezing.com"><img src="http://img.tongji.linezing.com/2359240/tongji.gif"/></a></noscript>
</body>
</html>