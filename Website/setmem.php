<?php
$mmc=memcache_init();
$key = $_REQUEST ['key'];
$value = $_REQUEST ['value'];

if($mmc!=false&&!empty($key)){
	//¿ª·ÅµÄkey
	if($key=="price"||$key=="news"||$key=="tech"||$key=="calendar"||$key=="count"||$key=="lastcalendar"){
		memcache_set($mmc,$key,$value);
		$output="y";
	}else{
		$output = "n";
	}
}else{
	$output = "f";
}
echo $output;
?>