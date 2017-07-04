<?php
include ('baseurl.php');

$lastquery=getmem('lastprice');
if($lastquery=="") $lastquery=1;
if(time()-$lastquery>15){
	$f = new SaeFetchurl();
	$data = $f->fetch($baseurl.'price_mem.php');
	setmem('price',$data);
	setmem('lastprice',time());
	echo $data;
}else{
	$s=getmem('price');
	echo $s;
}
/*
$s=getprice();
echo $s;
function getprice(){

 		$ch = curl_init ();
		curl_setopt ( $ch, CURLOPT_URL, "http://www.dailyfx.com.hk/inc/feed.php?type=price&_=" . time () );
		curl_setopt ( $ch, CURLOPT_REFERER, "http://www.dailyfx.com.hk" );
		curl_setopt ( $ch, CURLOPT_RETURNTRANSFER,true);
		curl_setopt ( $ch, CURLOPT_HEADER, 0 );
		$output = curl_exec ( $ch );
		curl_close ( $ch );

		//生成csv形式
		$currency = array ('EURUSD', 'USDJPY', 'GBPUSD', 'USDCHF', 'AUDUSD', 'USDCAD', 'NZDUSD' );
		$doc = new DOMDocument ( '1.0', 'utf-8' );
		$doc->loadXML ( $output );
		$doc->formatOutput = true;
		$doc->preserveWhiteSpace = false;
		$rates = $doc->getElementsByTagName ( "Rate" );
		
		$csv = '';
		foreach ( $rates as $rate ) {
			$symbol = $rate->getAttribute ( 'Symbol' );
			if (! in_array ( $symbol, $currency ))
				continue;
			
			$bid = $rate->getElementsByTagName ( 'Bid' )->item ( 0 )->nodeValue + 0;
			$ask = $rate->getElementsByTagName ( 'Ask' )->item ( 0 )->nodeValue + 0;
			$high = $rate->getElementsByTagName ( 'High' )->item ( 0 )->nodeValue + 0;
			$low = $rate->getElementsByTagName ( 'Low' )->item ( 0 )->nodeValue + 0;
			$direction = $rate->getElementsByTagName ( 'Direction' )->item ( 0 )->nodeValue;
			$time = $rate->getElementsByTagName ( 'Last' )->item ( 0 )->nodeValue;
			$csv = $csv . $symbol . "," . $bid . "," . $ask . "," . $high . "," . $low . "," . $direction . "," . $time . "\n";
			//$xml = $xml . $doc->saveXML ( $rate );
		}

	return $csv;
}
*/
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
