<?php
$servername="localhost";
$username="root";
$password="narivo2777";
$database="gestionbancaire";

$conn = mysqli_connect($servername,$username,$password,$database);

if(!$conn){
    die("connection failed:".mysqli_connect_error());    
}
?> 