<?php
$filename='calendar.htm';
$location='Location:http://leandro.132.china123.net/forex/';
if(!file_exists($filename)){
	getnews();
}else if(date('d',time())!=date('d',filemtime($filename))){
	getnews();
}
header($location.$filename);

function getnews(){
	if (function_exists('curl_init')){ 
		$ch=curl_init(); 
		curl_setopt($ch, CURLOPT_URL, "http://www.dailyfx.com.hk/calendar/index.php"); 
		curl_setopt($ch, CURLOPT_HEADER, 0); 
		curl_setopt($ch, CURLOPT_REFERER, "http://www.dailyfx.com.hk"); 
		$fp = fopen('calendar.htm', "w+");
		curl_setopt($ch, CURLOPT_FILE, $fp); 
		//curl_setopt($ch, CURLOPT_RETURNTRANSFER, 0);
		curl_setopt($ch, CURLOPT_USERAGENT, 'Mozilla/5.0 (Windows; U; Windows NT 5.1; )'); 
		curl_exec($ch); 
		curl_close($ch); 
		fclose($fp);
	} 
}
?>
