<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Page Title</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">

</head>

<body>
    <h1>Stand CRUD</h1>

    <a href="standLists.php">See the Stands lists</a>
    <a href="editStands.php">Edit Stands</a>

    <form action="index.php" method="post">
        Stand name
        <input type="text" name="standName"><br>
        Stand type
        <input type="text" name="standType"><br>
        Stand user
        <input type="text" name="standUser"><br>

        <input type="submit" value="Submit">
    </form>
</body>

</html>

<?php
require 'connection.php';
$standName = $_POST['standName'];
$standType = $_POST['standType'];
$standUser = $_POST['standUser'];

if ($standName != "") {
    print $standName . $standType . $standUser;
} else {
    print "everything looks fine";
}


$insert = "INSERT INTO Stands(nameStand,typeStand,userStand) VALUES ('" . $standName . "','" . $standType . "','" . $standUser . "');";
if ($standName == null || $standType == null || $standUser == null) {
    //echo "<script>alert('error');</script>";
} else {
    if ($conn->query($insert) == true) {
        echo "new record";
        $standName = null;
        $standType = null;
        $standUser = null;
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

?> 