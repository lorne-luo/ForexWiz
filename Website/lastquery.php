<?php
$mmc=memcache_init();
$key = "lastquery";

if($mmc!=false){
  $lastquery=memcache_get($mmc,$key);;
	if($lastquery==""){
		$lastquery=0;
	}
	if(time()-$lastquery>15)
		$output="y";
	else
		$output="n";
}else{
	$output = "n";
}
echo $output;
?>