<?php
$ver=$_GET["version"];
$ip = ($_SERVER["HTTP_VIA"]) ? $_SERVER["HTTP_X_FORWARDED_FOR"] : $_SERVER["REMOTE_ADDR"]; 

if($ver=='1.0.1.0'){
	$message='隧道股份';
	$success='true';
}else if($ver=='1.0.2.0'){
	$message='隧道股份2354235';
	$success='false';
}

echo $success."|".$message;

?>
