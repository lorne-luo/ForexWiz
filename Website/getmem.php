<?php
$mmc=memcache_init();
$key = $_GET ['key'];


if($mmc!=false&&!empty($key)){
  $output=memcache_get($mmc,$key);
	if($output==""){
		$output="n";
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
}else{
	$output = "f";
}
echo $output;
?>