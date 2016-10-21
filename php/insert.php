<?PHP
$hostname_localhost ="localhost";  //nuestro servidor
$database_localhost ="joseluis";//Nombre de nuestra base de datos
$username_localhost ="joseluis";//Nombre de usuario de nuestra base de datos (yo utilizo el valor por defecto)
$password_localhost ="Nahyr17.7";//Contraseña de nuestra base de datos (yo utilizo por defecto)
$localhost = mysql_connect($hostname_localhost,$username_localhost,$password_localhost)//Conexión a nuestro servidor mysql
or
trigger_error(mysql_error(),E_USER_ERROR); //mensaaje de error si no se puede conectar
mysql_select_db($database_localhost, $localhost);//seleccion de la base de datos con la qu se desea trabajar

//variables que almacenan los valores que enviamos por nuestra app, (observar que se llaman igual en nuestra app y aqui)
$nombre=$_POST['nombre'];
$dni=$_POST['dni'];
$telefono=$_POST['telefono'];
$email=$_POST['email'];

$query_search = "insert into personas(nombre,dni,telefono,email) values ('".$nombre."','".$dni."','".$telefono."','".$email."')";//Sentencia sql a realizar
$query_exec = mysql_query($query_search) or die(mysql_error());//Ejecuta la sentencia sql.
?>
