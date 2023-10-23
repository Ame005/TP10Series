using System.Data.SqlClient;
using Dapper;
public class BD {
    private static string _connectionString = @"Server=.;Database=script;Trusted_Connection=True;";
    public static List<Serie> ObtenerSeries(){
        List<Serie> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            devolver = db.Query<Serie>(sql).ToList();
        }
        return devolver;
    }
    public static List<Actor> ObtenerActores(int idSerie){
        List<Actor> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @IdSerie";
            devolver = db.Query<Actor>(sql, new{IdSerie = idSerie}).ToList();
        }
        return devolver;
    }
    public static List<Temporada> ObtenerTemporadas(int idSerie){
        List<Temporada> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @IdSerie";
            devolver = db.Query<Temporada>(sql, new{IdSerie = idSerie}).ToList();
        }
        return devolver;
    }
    public static Serie ObtenerInfoSerie(int idSerie){
        Serie devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series WHERE IdSerie = @IdSerie";
            devolver = db.QueryFirstOrDefault<Serie>(sql, new{IdSerie = idSerie});
        }
        return devolver;
    }
}