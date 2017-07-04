<?php
$filename='tech.htm';
$location='Location:http://leandro.132.china123.net/forex/';
if(!file_exists($filename)){
	getnews();
}else if(time()-filemtime($filename)>60){
	getnews();
}
header($location.$filename);

function getnews(){
	if (function_exists('curl_init')){ 
		$ch=curl_init(); 
		curl_setopt($ch, CURLOPT_URL, 'http://www.dailyfx.com.hk/techs/index.php'); 
		curl_setopt($ch, CURLOPT_HEADER, 0); 
		curl_setopt($ch, CURLOPT_REFERER, 'http://www.dailyfx.com.hk'); 
		$fp = fopen('tech.htm', "w+");
		curl_setopt($ch, CURLOPT_FILE, $fp); 
		curl_setopt($ch, CURLOPT_USERAGENT, 'Mozilla/5.0 (Windows; U; Windows NT 5.1; )'); 
		curl_exec($ch); 
		curl_close($ch); 
		fclose($fp);
	} 
}

?>
