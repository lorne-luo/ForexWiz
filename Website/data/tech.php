<?php
include ('baseurl.php');

$lastquery=getmem('lasttech');
if($lastquery=="") $lastquery=1;
if(time()-$lastquery>15){
	$f = new SaeFetchurl();
	$data = $f->fetch($baseurl.'tech_mem.php');
	setmem('tech',$data);
	setmem('lasttech',time());
	echo $data;
}else{
	$s=getmem('tech');
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
		//ֻ��ҵ��ż���
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
