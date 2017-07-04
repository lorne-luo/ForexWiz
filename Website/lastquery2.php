<?php
$mmc=memcache_init();
$key = "lastquery";

if($mmc!=false){
  $lastquery=memcache_get($mmc,$key);;
	if($lastquery==""){
		$lastquery=0;
	}else{
		$lastquery=date('Y-m-d H:i:s',$lastquery);
	}
}else{
	$lastquery = "n";
}
echo $lastquery;
?>