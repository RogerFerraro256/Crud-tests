<?php
$servername = "localhost";
$username = "root";
$password = "1234";
$db = "crud";

// Create connection
$conn = new mysqli($servername, $username, $password,$db);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 
//echo "<script>alert('connected')</script>";
?>