<?php
require 'connection.php';

$result = mysqli_query($conn,"select * from Stands");

$btn = $_POST['stand'];



echo "
<a href='index.php'>go Back</a>
<a href='editStands.php'>Edit Stands</a>

<form action='standLists.php' method='post'>
<table border='1'>
<tr>
<th>Id Stand</th>
<th>Stand Name</th>
<th>Stand Type</th>
<th>Stand User</th>
</tr>";

while($row=mysqli_fetch_array($result)){
    echo "<tr>";
    echo "<td>" . $row['idStands'] . "</td>";
    echo "<td>" . $row['nameStand'] . "</td>";
    echo "<td>" . $row['typeStand'] . "</td>";
    echo "<td>" . $row['userStand'] . "</td>";
    echo "<td><input type='submit' value='".$row['idStands']."' name='stand' onclick='shiet()'></td>"; 
    echo "</tr>";
}
echo "</table>
</form>";

$sql = "DELETE FROM Stands WHERE idStands=".$btn;

if ($conn->query($sql) === TRUE) {
    echo "Record deleted successfully";
} else {
    //echo "Error deleting record: " . $conn->error;
}



?>