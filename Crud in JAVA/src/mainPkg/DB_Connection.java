package mainPkg;

import java.util.ArrayList;
import java.util.List;
import java.sql.*;

public class DB_Connection {

	private String dbURL = "jdbc:mysql://localhost:3306/fleet";
	private String user = "root";
	private String password = "1234";
	private Connection con;
	private Statement query;
	private String name2;
	private String type2;

	public boolean open() {
		try {
			con = DriverManager.getConnection(dbURL, user, password);
			System.out.println("aberta");
			return true;
		} catch (Exception e) {
			e.printStackTrace();
		}

		return false;
	}

	public boolean close() {
		try {
			con.close();
			System.out.println("fechado");
			return true;
		} catch (Exception e) {
			e.printStackTrace();
		}
		return false;
	}

	public void insert(String name, String type) {
		// TODO Auto-generated method stub
		String sql = "INSERT INTO ships(nameShip,typeShip) values('" + name + "','" + type + "');";
		open();

		try {
			query = con.createStatement();
			query.execute(sql);
			System.out.println("success");
			close();
		} catch (Exception e) {
			// TODO: handle exception
		}

	}

	public void update(String name, String type, int id) {
		String sql;
		if (name == null || name.isEmpty()) {
			sql = "UPDATE ships SET typeShip = '" + type + "' WHERE idships=" + id + ";";
		}
		if (type == null || type.isEmpty()) {
			sql = "UPDATE ships SET nameship = '" + name + "' WHERE idships=" + id + ";";
		} else {
			sql = "UPDATE ships SET nameship = '" + name + "', typeShip = '" + type + "' WHERE idships=" + id + ";";
		}
		System.out.println(sql);

		try {
			query = con.createStatement();
			query.execute(sql);
			close();
			System.out.println("foi");
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public ArrayList<String> selectSpecific(String name, String type, String id) {
		String sql = "";
		ArrayList<String> result = new ArrayList<>();

		if (name != null || name == "") {
			sql = "select * from ships where nameShip='" + name + "';";
		}
		if (type != null || type == "") {
			sql = "select * from ships where typeShip='" + type + "';";
		}
		if (id != null || id == "") {
			sql = "select * from ships where idShips=" + id;
		}
		System.out.println(sql);
		try {
			open();
			query = con.createStatement();
			ResultSet rs = query.executeQuery(sql);
			while (rs.next()) {
				result.add(rs.getString("idships"));
				result.add(rs.getString("nameShip"));
				result.add(rs.getString("typeShip"));

			}

			close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return result;
	}

	public void selectColumn(String name, String type, String id) {
		String sql = "";
		if (name != null) {
			sql = "SELECT nameShip from ships";
		}
		if (type != null) {
			sql = "SELECT typeShip from ships";
		}
		if (id != null) {
			sql = "SELECT idShips from ships";
		}

		try {
			open();
			query = con.createStatement();
			ResultSet rs = query.executeQuery(sql);
			while (rs.next()) {
				String ids = rs.getString("idships");
				String ship = rs.getString("nameShip");
				String typeS = rs.getString("typeShip");
				System.out.println(ids + ship + typeS);
			}

			close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public ArrayList<String> select() {
		String sql;
		ArrayList<String> result = new ArrayList<>();

		sql = "select * from ships";

		System.out.println(sql);
		try {
			open();
			query = con.createStatement();
			ResultSet rs = query.executeQuery(sql);
			while (rs.next()) {
				result.add(rs.getString("idships"));
				result.add(rs.getString("nameShip"));
				result.add(rs.getString("typeShip"));

			}

			close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return result;

	}
	
	public void delete(int id) {
		String sql = "DELETE FROM ships WHERE idships="+id+";";
		open();

		try {
			query = con.createStatement();
			query.execute(sql);
			System.out.println("success");
			close();
		} catch (Exception e) {
			// TODO: handle exception
		}

	}
	

}
