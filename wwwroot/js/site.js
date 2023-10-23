// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarActores(idSerie,nombre){
    $.ajax({
            type: 'GET',
            datatype: 'JSON',
            url: '/Home/VerActores',
            data: {idS: idSerie},
            success:
                function(response){
                    let actores="";
                    $("#Titulo").html("Cantidad de Actores "+ nombre + ": " + response.length);
                    for(const actor of response){
                        actores = actores + actor.nombre + "<br>"
                    }
                    $("#Cuerpo").html(actores);
                }
        });
}
function MostrarTemporadas(idSerie,nombre){
    $.ajax({
            type: 'GET',
            datatype: 'JSON',
            url: '/Home/VerTemporadas',
            data: {idS: idSerie},
            success:
                function(response){
                    let temporadas= "";
                    $("#Titulo").html("Cantidad de Temporadas "+ nombre + ": " + response.length);
                    for(const temporada of response){
                        temporadas = temporadas + temporada.numeroTemporada + ": " + temporada.tituloTemporada + "<br>"
                    }
                    $("#Cuerpo").html(temporadas)
                }
        });
}
function MostrarInfo(idSerie,nombre){
    $.ajax({
        type: 'GET',
        datatype: 'JSON',
        url: '/Home/VerInfoSerie',
        data: {idS: idSerie},
        success:
            function(response){
                $("#Titulo").html("Curiosidades de " + nombre)
                $("#Cuerpo").html("Año de inicio: " + response.anioInicio + "<br>" + "Sinopsis: " + response.sinopsis)
            }
    });
}
