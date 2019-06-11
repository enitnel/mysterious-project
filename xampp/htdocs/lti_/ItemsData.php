<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbName = "lti";

//Make connection
$conn = new mysqli($servername, $username,$password, $dbName);
//Check connection
if(!$conn)
{
	die("Connection Failed.". mysqli_connect_error());
}
//else echo("Connection Success");

$sql = "SELECT stamina_lvl FROM person WHERE person_id=3";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0)
{
	//show data for each row
	while($row = mysqli_fetch_assoc($result))
	{
		echo /*"person_id:".$row["person_id"] . "|person_name:".$row["person_name"] . "|health_lvl:". $row["health_lvl"] . */"|stamina_lvl:". $row["stamina_lvl"] . ";";
	}
}



?>