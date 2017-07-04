<?php
include ('baseurl.php');

$lastquery=getmem('lastcalendar');
if($lastquery=="") $lastquery=1;
if(date("d")!=$lastquery){
	$f = new SaeFetchurl();
	$data = $f->fetch($baseurl.'calendar_mem.php');
	setmem('calendar',$data);
	setmem('lastcalendar',date("d"));
	echo $data;
}else{
	$s=getmem('calendar');
	echo $s;
}

function setmem($key,$value){
	$mmc=memcache_init();
	if($mmc!=false&&!empty($key)){
		memcache_set($mmc,$key,$value);
	}
}

function getmem($key){
	$mmc=memcache_init();
	$output=memcache_get($mmc,$key);
	if($output==""){
		$output="0";
	}else{
		//只有业务才计数
		if($key=="price"||$key=="news"||$key=="tech"||$key=="calendar"){
			memcache_set($mmc,"lastquery",time());
			$count=memcache_get($mmc,"count");
			if($count=="")
				memcache_set($mmc,"count",1);
			else
				memcache_set($mmc,"count",$count+1);
		}
	}
	return $output;
}
?>
