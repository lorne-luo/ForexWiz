<?php
$lastquery=getmem('last500px');
if($lastquery=="") $lastquery=0;
if(date("h")!=$lastquery){
	$f = new SaeFetchurl();
	$data = $f->fetch('http://leandro.132.china123.net/android/colorfulsearch/500px.php?n=3');//
	if(strlen($data)>50){
		setmem('500px',$data);
		setmem('last500px',date("h"));
		echo $data;
	}
}else{
	$s=getmem('500px');
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
