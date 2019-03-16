<?php
require 'connection.php';
$result = mysqli_query($conn,"select * from Stands");


$nameStand = $_POST['nameStand'];
$typeStand = $_POST['typeStand'];
$userStand = $_POST['userStand'];
$btn = $_POST['stand'];

echo $nameStand;

echo "
<a href='index.php'>go Back</a>

<table border='1'>
<tr>
<th>Id Stand</th>
<th>Stand Name</th>
<th>Stand Type</th>
<th>Stand User</th>
</tr>";

while($row=mysqli_fetch_array($result)){
    echo "<tr>";
    echo"<form action='editStands.php' method='post'>";
    echo "<td>" . $row['idStands'] . "</td>";
    echo "<td><input type='text' name='nameStand' placeholder=" . $row['nameStand'] . "></td>";
    echo "<td><input type='text' name='typeStand' placeholder=" . $row['typeStand'] . "></td>";
    echo "<td><input type='text' name='userStand' placeholder=" . $row['userStand'] . "></td>";
    echo "<td><input type='submit' value='".$row['idStands']."' name='stand' onclick='shiet()'></td>"; 
    echo "</form>
    </tr>";
}
echo "</table>";



$sql = "UPDATE Stands SET nameStand='".$nameStand."' , typeStand='".$typeStand."' , userStand ='".$userStand."' WHERE idStands=".$btn;

//echo $sql;


if (mysqli_query($conn, $sql)) {
    //echo "Record updated successfully";
} else {
    //echo "Error updating record: " . mysqli_error($conn);
}


?>