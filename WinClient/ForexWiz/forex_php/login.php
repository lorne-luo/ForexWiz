<?php
$ver=$_GET["version"];
$ip = ($_SERVER["HTTP_VIA"]) ? $_SERVER["HTTP_X_FORWARDED_FOR"] : $_SERVER["REMOTE_ADDR"]; 

if($ver=='1.0.1.0'){
	$message='����ɷ�';
	$success='true';
}else if($ver=='1.0.2.0'){
	$message='����ɷ�2354235';
	$success='false';
}

echo $success."|".$message;

?>
