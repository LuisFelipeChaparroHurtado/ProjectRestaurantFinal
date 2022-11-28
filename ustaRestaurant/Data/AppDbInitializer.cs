﻿using Microsoft.AspNetCore.Identity;
using ustaRestaurant.Data.Static;
using ustaRestaurant.Models;

namespace ustaRestaurant.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //ProductType
                if (!context.ProductTypes.Any())
                {
                    context.ProductTypes.AddRange(new List<ProductType>()
                    {
                        new ProductType()
                        {
                            Name="Antipasto (Entrada)"
                        },
                        new ProductType()
                        {
                            Name="Crema"
                        },
                        new ProductType()
                        {
                            Name="Lassagna"
                        },
                        new ProductType()
                        {
                            Name="Pizza"
                        },
                        new ProductType()
                        {
                            Name="Spaguetti"
                        },
                        new ProductType()
                        {
                            Name="Canelones"
                        },
                        new ProductType()
                        {
                            Name="Raviolis"
                        },
                        new ProductType()
                        {
                            Name="Crep"
                        },
                        new ProductType()
                        {
                            Name="Pan Pienno"
                        },
                        new ProductType()
                        {
                            Name="Cazuela"
                        },
                        new ProductType()
                        {
                            Name="Pescado"
                        },
                        new ProductType()
                        {
                            Name="Menú Infantil"
                        },
                        new ProductType()
                        {
                            Name="Bebida"
                        },
                        new ProductType()
                        {
                            Name="Cerveza"
                        },
                        new ProductType()
                        {
                            Name="Licor"
                        },
                        new ProductType()
                        {
                            Name="Cóctel"
                        },
                    });
                    context.SaveChanges();
                }
                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                          new Product()
                            {
                             Name= "Bruschetas",
                             Description="Pan tostado, tomate, orégano, aceite de oliva y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/Bruschetas.jpg",
                             Price=17000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Capresse",
                             Description="Tomate fresco, jamón serrano, albahaca, queso campesino y aceituna",
                             Image= "http://localhost/img/ustaRestaurante/product/Crapese.jpg",
                             Price=15000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Ensalada de la Casa",
                             Description="Lechuga, aceituna, tomate, queso campesino, brocoli, coliflor, pepinillos, habichuela ",
                             Image= "http://localhost/img/ustaRestaurante/product/EnsaladaCasa.jpg",
                             Price=18000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Empanadas de la Casa",
                             Description="Carne o Queso o Mixtas (6 Unidades)​",
                             Image= "http://localhost/img/ustaRestaurante/product/EmpanadasCasa.jpg",
                             Price=14000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Ensalda Frutos del Mar",
                             Description="Esta propuesta de ensaladas diferentes, es elegante y sabrosa. El penetrante sabor del salmón ahumado pone una nota perfecta a la frescura de los pepinos y la fragancia de las hierbas.",
                             Image= "http://localhost/img/ustaRestaurante/product/EnsaladaFrutosMar.jpg",
                             Price=25000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Cestini en trío de Patacón",
                             Description="Canastillas de Patacón, Rellenas con camarones, salsa fungui o pollo y champiñones (3 Unidades)",
                             Image= "http://localhost/img/ustaRestaurante/product/Patacon.jpg",
                             Price=28000.0,
                             ProductTypeId=1
                            },
                        new Product()
                            {
                             Name= "Crema del Día",
                             Description="Tomate, Espinaca, Pollo o Pollo y Champiñones​",
                             Image= "http://localhost/img/ustaRestaurante/product/Crema.jpg",
                             Price=15000.0,
                             ProductTypeId=2
                            },
                        new Product()
                            {
                             Name= "Lassagna Sabor y Arte",
                             Description="Salsa Bolognesa, Queso, Salsa Bechamel, Jamón y Pollo​",
                             Image= "http://localhost/img/ustaRestaurante/product/LassanaSaborArte.jpg",
                             Price=27000.0,
                             ProductTypeId=3
                            },
                        new Product()
                            {
                             Name= "Lassagna Pollo y Champiñones",
                             Description="Salsa bechamel, Queso, Pollo y Champiñones​",
                             Image= "http://localhost/img/ustaRestaurante/product/LassanaPollo.jpg",
                             Price=28000.0,
                             ProductTypeId=3
                            },
                        new Product()
                            {
                             Name= "De Temporada",
                             Description="​",
                             Image= "http://localhost/img/ustaRestaurante/product/PizzaTemporada.jpg",
                             Price=28000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Putanesca",
                             Description="Especialidad de la casa. Posibilidad de elegir de 2 a 4 sabores​",
                             Image= "http://localhost/img/ustaRestaurante/product/PizzaPutanesca.jpg",
                             Price=20000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Sabor y Arte",
                             Description="Tomate, tocineta, salami maíz, champiñón, pollo y aceitunas",
                             Image= "http://localhost/img/ustaRestaurante/product/PizzaSaborArte.jpg",
                             Price=20000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Diavola",
                             Description="Chorizo picante, salami, queso, pimetón, tomate, cabanos",
                             Image= "http://localhost/img/ustaRestaurante/product/Diaviola.jpg",
                             Price=19000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Pollo con Champiñones",
                             Description="Pollo y champiñones​",
                             Image= "http://localhost/img/ustaRestaurante/product/PolloChampi.jpg",
                             Price=19000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Fungui",
                             Description="Tomate, champiñones, orégano y aceite de oliva​",
                             Image= "http://localhost/img/ustaRestaurante/product/Fungui.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Calabreza",
                             Description="Chorizo Ahumado, cebolla caramelizada​",
                             Image= "http://localhost/img/ustaRestaurante/product/Calabreza.jpg",
                             Price=19000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Hawaiana",
                             Description="Piña, jamón y queso​",
                             Image= "http://localhost/img/ustaRestaurante/product/Hawaiana.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Ciruela Pasas con Tocineta",
                             Description="Tocineta y ciruelas pasas​",
                             Image= "http://localhost/img/ustaRestaurante/product/CiruelasTocineta.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Tropical",
                             Description="Durazno, Cereza, Ciruela y piña​",
                             Image= "http://localhost/img/ustaRestaurante/product/Tropical.jpg",
                             Price=17000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Cuatro Quesos",
                             Description="Mozzarela, doble crema, queso fresco y queso paipa​",
                             Image= "http://localhost/img/ustaRestaurante/product/Queso.jpg",
                             Price=20000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Ortolana",
                             Description="Vegetariana (Brocoli, coliflor, maíz, champiñones, pimentón)​",
                             Image= "http://localhost/img/ustaRestaurante/product/Ortolana.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Napolitana",
                             Description="Tomate y albahaca​",
                             Image= "http://localhost/img/ustaRestaurante/product/Napolitana.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "De la Huerta",
                             Description="Espinaca, tomate, champiñon y aceituna​",
                             Image= "http://localhost/img/ustaRestaurante/product/Huerta.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Mexicana",
                             Description="Carne, pico de gallo y tajín​",
                             Image= "http://localhost/img/ustaRestaurante/product/Mexicana.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Criolla",
                             Description="Pollo o Carne o Mixta, maíz",
                             Image= "http://localhost/img/ustaRestaurante/product/Criolla.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Verde",
                             Description="Salsa pesto, espinaca, pepinillo, brócoli, arveja y habichuela​",
                             Image= "http://localhost/img/ustaRestaurante/product/Verde.jpg",
                             Price=15000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Carbonara",
                             Description="Salsa Bechamel, tocineta, huevo de codorniz ​",
                             Image= "http://localhost/img/ustaRestaurante/product/Carbonara.jpg",
                             Price=17000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Camarones",
                             Description="Camarones y pimentón​",
                             Image= "http://localhost/img/ustaRestaurante/product/Camarones.jpg",
                             Price=20000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Pepperoni",
                             Description="Pepperoni​",
                             Image= "http://localhost/img/ustaRestaurante/product/Peperoni.jpg",
                             Price=20000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Sposata",
                             Description="Bocadillo y queso​",
                             Image= "http://localhost/img/ustaRestaurante/product/Soposata.jpg",
                             Price=18000.0,
                             ProductTypeId=4
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Bolognesa",
                             Description="Salsa ragú, carne molida, especies y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpaguettiBolanesa.jpg",
                             Price=26000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti con Pollo y Champiñones",
                             Description="Pollo con champiñones​ y queso gratinado",
                             Image= "http://localhost/img/ustaRestaurante/product/SpaguettiPollo.jpg",
                             Price=29000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Carbonara",
                             Description="Salsa bechamel, tocineta ahumada, huevo(yema) y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpaguettiCarbonala.jpg",
                             Price=29000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Marinera",
                             Description="Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar), salsas y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/Marinera.jpg",
                             Price=42000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti en Salsa Napolitana",
                             Description="Salsa ragú, aceite de oliva, albahaca y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpagueNapolitana.jpg",
                             Price=24000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Ortolana",
                             Description="Brocoli, coliflor, champiñones, tomate, maíz, pimentón y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SapaOrolana.jpg",
                             Price=24000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti al Pesto",
                             Description="Aceite de Oliva, Nueces, albahaca y queso parmesano​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpagPesto.jpg",
                             Price=22000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti con Albondigas",
                             Description="Salsa Napolitana, albondigas de carne de res y queso parmesano​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpagueAlbondigas.jpg",
                             Price=30000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Parmellana",
                             Description="Salsa napolitana, bife de Pollo, albahaca y queso parmesano​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpageParmellana.jpg",
                             Price=32000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti a la Matriciana",
                             Description="Salsa Napolitana, peperoni, cebolla roja, picante y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpagMtriciana.jpg",
                             Price=34000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti Sabor y Arte",
                             Description="Salsa bechamel, tocineta, champiñó​n, maíz, aceituna, salami, camarón y queso gratinado",
                             Image= "http://localhost/img/ustaRestaurante/product/SapgueSaborArte.jpg",
                             Price=38000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti Fungui",
                             Description="Salsa pomodoro, champiñones y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpaguetiFungi.jpg",
                             Price=30000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Spaguetti Alfredo",
                             Description="Salsa bechamel, jamón, crema de leche y queso parmesano​",
                             Image= "http://localhost/img/ustaRestaurante/product/SpagAlfredo.jpg",
                             Price=28000.0,
                             ProductTypeId=5
                            },
                        new Product()
                            {
                             Name= "Canelones de Carne o Pollo o Mixtos",
                             Description="Salsas(Ragú o Bechamel), aceite de oliva albahaca y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CanelonesCarne.jpg",
                             Price=29000.0,
                             ProductTypeId=6
                            },
                        new Product()
                            {
                             Name= "Canelones a la Ortolana",
                             Description="Salsa bechamel, brocoli, coliflor, champiñones, tomate, maíz, pimentón y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CanelonesOrtolana.jpg",
                             Price=26000.0,
                             ProductTypeId=6
                            },
                        new Product()
                            {
                             Name= "Canelones Espinaca y Ricota",
                             Description="Salsa bechamel, espinaca, queso ricota y queso gratinado ​",
                             Image= "http://localhost/img/ustaRestaurante/product/CanelonesEspinaca.jpg",
                             Price=26000.0,
                             ProductTypeId=6
                            },
                        new Product()
                            {
                             Name= "Canelones Frutos del Mar",
                             Description="Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar), salsas y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CanelonesMar.jpg",
                             Price=42000.0,
                             ProductTypeId=6
                            },
                        new Product()
                            {
                             Name= "Canelones Fungui",
                             Description="Salsa napolitana, champiñones y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CanelonesFungui.jpg",
                             Price=28000.0,
                             ProductTypeId=6
                            },
                        new Product()
                            {
                             Name= "Raviolis de Carne",
                             Description="Salsa Bolognesa, orégano y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/RaviolisCarne.jpg",
                             Price=26000.0,
                             ProductTypeId=7
                            },
                        new Product()
                            {
                             Name= "Raviolis de Queso",
                             Description="Salsa bechamel con quesos, albahaca y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/RaviolisQueso.jpg",
                             Price=27000.0,
                             ProductTypeId=7
                            },
                        new Product()
                            {
                             Name= "Creps Pollo y Champiñon",
                             Description="Salsa bechamel, pollo con champiñones​ y queso gratinado",
                             Image= "http://localhost/img/ustaRestaurante/product/CrepsPollo.jpg",
                             Price=25000.0,
                             ProductTypeId=8
                            },
                        new Product()
                            {
                             Name= "Creps Tropical",
                             Description="Salsa blanca, crema de leche, cereza, durazno, piña y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CrepsTropica.jpg",
                             Price=24000.0,
                             ProductTypeId=8
                            },
                        new Product()
                            {
                             Name= "Creps Frutos dell Mar",
                             Description="Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar), salsas y queso gratinado​",
                             Image= "http://localhost/img/ustaRestaurante/product/CrepsFrutosMar.jpg",
                             Price=32000.0,
                             ProductTypeId=8
                            },
                        new Product()
                            {
                             Name= "Creps Ortolana",
                             Description="Salsa bechamel, brocoli, coliflor, champiñones, tomate, maíz, pimentón y queso gratinado​​",
                             Image= "http://localhost/img/ustaRestaurante/product/CrepsOrtolana.jpg",
                             Price=25000.0,
                             ProductTypeId=8
                            },
                         new Product()
                            {
                             Name= "Pan Frutos del Mar",
                             Description="Pan relleno de Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar) en salsas y queso gratinado​​",
                             Image= "http://localhost/img/ustaRestaurante/product/PanFrutosMar.jpg",
                             Price=42000.0,
                             ProductTypeId=9
                            },
                        new Product()
                            {
                             Name= "Pan Pollo y Champiñon",
                             Description="Pan relleno de pollo, champiñones en salsa bechamel y queso gratinado",
                             Image= "http://localhost/img/ustaRestaurante/product/PanPollo.jpg",
                             Price=27000.0,
                             ProductTypeId=9
                            },
                        new Product()
                            {
                             Name= "Pan Ortolana",
                             Description="Pan relleno de brocoli, coliflor, champiñones, tomate, maíz, pimentón en salsa bechamel y queso gratinado​​",
                             Image= "http://localhost/img/ustaRestaurante/product/PanOrtolana.jpg",
                             Price=25000.0,
                             ProductTypeId=9
                            },
                        new Product()
                            {
                             Name= "Pan Sabor y Arte",
                             Description="Pan relleno de tocineta, champiñó​n, maíz, aceituna, salami, camarón en salsa bechamel y queso gratinado​​",
                             Image= "http://localhost/img/ustaRestaurante/product/PanSaborArte.jpg",
                             Price=32000.0,
                             ProductTypeId=9
                            },
                        new Product()
                            {
                             Name= "Pan Fungui",
                             Description="Salsa pomodoro, champiñones y queso gratinado ​​",
                             Image= "http://localhost/img/ustaRestaurante/product/PanFungui.jpg",
                             Price=28000.0,
                             ProductTypeId=9
                            },
                        new Product()
                            {
                             Name= "Cazuela de Mariscos",
                             Description="Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar), salsas y queso gratinado​​. Acompañada de porción de arroz y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/CazuelaMariscos.jpg",
                             Price=42000.0,
                             ProductTypeId=10
                            },
                        new Product()
                            {
                             Name= "Trucha gratinada",
                             Description="Trucha (350gr - 450gr) con especies (pimentón, perejil, limón, sal, especies) con queso gratinado. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/TruchaGratinada.jpg",
                             Price=38000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Trucha al Horno con Especies",
                             Description="Trucha (350gr - 450gr) con especies (pimentón, perejil, limón, sal, especies)​​. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/TruchaHorno.jpg",
                             Price=36000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Trucha con Frutos del Mar",
                             Description="Trucha (350gr - 450gr) con especies (pimentón, perejil, limón, sal, especies), Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar) en salsas y queso gratinado. Acompañada de porción de spaguetti a la albahaca y porción de ensalada​​",
                             Image= "http://localhost/img/ustaRestaurante/product/TruchaFrutosMar.jpg",
                             Price=49000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Trucha Hawaiana",
                             Description="Trucha (350gr - 450gr) con especies (pimentón, perejil, limón, sal, especies)​​, con jamón, piña y queso gratinado. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/Truchahawaiana.jpg",
                             Price=37000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Trucha al Ajillo",
                             Description="Trucha (350gr - 450gr) con especies (pimentón, perejil, limón, sal, especies)​​, con salsa a base de ajo y perejil. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/TruchaAjillo.jpg",
                             Price=36000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Salmón Gratinado",
                             Description="Salmón (250gr - 300gr) con especies (pimentón, perejil, limón, sal, especies, vino blanco)​​, con queso gratinado. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/SalmonGratinado.jpg",
                             Price=39000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Salmón al Horno con Especies",
                             Description="Salmón (250gr - 300gr) con especies (pimentón, perejil, limón, sal, especies, vino blanco)​​. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/SalmonHorno.jpg",
                             Price=39000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Salmón al Horno con Frutos del Mar",
                             Description="Salmón (250gr - 300gr) con especies (pimentón, perejil, limón, sal, especies, vino blanco)​​, Frutos del mar (Camarones, palmitos, pulpo, mejillones, anillos de calamar) en salsas y queso gratinado. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/SalmonFrutosMar.jpg",
                             Price=49000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Salmón Sabor y Arte",
                             Description="Salmón (250gr - 300gr) con especies (pimentón, perejil, limón, sal, especies, vino blanco)​​, cama en salsa pomodoro y camarones en salsa Pesto. Acompañada de porción de spaguetti a la albahaca y porción de ensalada",
                             Image= "http://localhost/img/ustaRestaurante/product/SalmonSaborArtre.jpg",
                             Price=48000.0,
                             ProductTypeId=11
                            },
                        new Product()
                            {
                             Name= "Menú Infantil",
                             Description="Nuggets de pollo, papa a la francesa, copa de helado y jugo",
                             Image= "http://localhost/img/ustaRestaurante/product/MenuInfantil.jpg",
                             Price=25000.0,
                             ProductTypeId=12
                            },
                        new Product()
                            {
                             Name= "Jugo Natural de Fresa",
                             Description="Bebida refrescante con frutas naturales",
                             Image= "http://localhost/img/ustaRestaurante/product/JugoFresa.jpg",
                             Price=7500.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Jugo Natural de Mora",
                             Description="Bebida refrescante con frutas naturales",
                             Image= "http://localhost/img/ustaRestaurante/product/JugoMora.jpg",
                             Price=7500.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Jugo Natural de Maracuya",
                             Description="Bebida refrescante con frutas naturales",
                             Image= "http://localhost/img/ustaRestaurante/product/JugoMaracuya.jpg",
                             Price=7500.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Jugo Natural de Lulo",
                             Description="Bebida refrescante con frutas naturales",
                             Image= "http://localhost/img/ustaRestaurante/product/JugoLulo.jpg",
                             Price=7500.0,
                             ProductTypeId=13
                            },

                        new Product()
                            {
                             Name= "Jugo Natural de Mango",
                             Description="Bebida refrescante con frutas naturales",
                             Image= "http://localhost/img/ustaRestaurante/product/JugoMango.jpg",
                             Price=7500.0,
                             ProductTypeId=13
                            },

                        new Product()
                            {
                             Name= "Limonada Natural",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/LimonadaNatural.jpg",
                             Price=7000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Limonada Hierbabuena",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/LimonadaHierbabuena.jpg",
                             Price=8000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Té Helado",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/TeHelado.jpg",
                             Price=7000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Gaseosa Coca-Cola",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/CocaCola.jpg",
                             Price=5000.0,
                             ProductTypeId=13
                            },

                        new Product()
                            {
                             Name= "Gaseosa Sprite",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/Sprite.jpg",
                             Price=5000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Malteada",
                             Description="Bebida elaborada a base de leche o helado",
                             Image= "http://localhost/img/ustaRestaurante/product/Malteada.jpg",
                             Price=13000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Botella de Agua",
                             Description="Bebida refrescante",
                             Image= "http://localhost/img/ustaRestaurante/product/BotellaAgua.jpg",
                             Price=4500.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Copa de Helado",
                             Description="Formato de presentación del helado",
                             Image= "http://localhost/img/ustaRestaurante/product/Helado.jpg",
                             Price=12000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Ponche Flor de Jamaica",
                             Description="Cóctel que contiene un té a base de la flor de jamaica con un batido con la clara de huevo y leche condensada",
                             Image= "http://localhost/img/ustaRestaurante/product/PoncheFlorJamaica.jpg",
                             Price=12000.0,
                             ProductTypeId=13
                            },
                        new Product()
                            {
                             Name= "Vino de Verano",
                             Description="Cóctel a base de soda y vino tinto Cabernet con sumo de limón",
                             Image= "http://localhost/img/ustaRestaurante/product/VinoVernao.jpg",
                             Price=12000.0,
                             ProductTypeId=13
                            },

                        new Product()
                            {
                             Name= "Cerveza Club Colombia",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/ClubColombia.jpg",
                             Price=8000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Cerveza Aguila Tradicional",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/Auila.jpg",
                             Price=7000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Cerveza Poker",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/Poker.jpg",
                             Price=6000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Cerveza Corona",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/Corona.jpg",
                             Price=12000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Cerveza Artesanal",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/Artesanal.jpg",
                             Price=12000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Cerveza Stella",
                             Description="Bebida alcohólica",
                             Image= "http://localhost/img/ustaRestaurante/product/Stella.jpg",
                             Price=12000.0,
                             ProductTypeId=14
                            },
                        new Product()
                            {
                             Name= "Vino de la casa (Botella)",
                             Description="Licor",
                             Image= "http://localhost/img/ustaRestaurante/product/VinoCasa.jpg",
                             Price=78000.0,
                             ProductTypeId=15
                            },

                        new Product()
                            {
                             Name= "Vino de la casa (Copa)",
                             Description="Licor",
                             Image= "http://localhost/img/ustaRestaurante/product/CopaVino.jpg",
                             Price=12000.0,
                             ProductTypeId=15
                            },
                        new Product()
                            {
                             Name= "Whisky Sello Rojo (Botella)",
                             Description="Licor",
                             Image= "http://localhost/img/ustaRestaurante/product/SelloRojo.jpg",
                             Price=140000.0,
                             ProductTypeId=15
                            },
                        new Product()
                            {
                             Name= "Whisky Old Parr (Botella)",
                             Description="Licor",
                             Image= "http://localhost/img/ustaRestaurante/product/OldPar.jpg",
                             Price=190000.0,
                             ProductTypeId=15
                            },

                        new Product()
                            {
                             Name= "Copa de Vino Caliente",
                             Description="Vino Cabernet",
                             Image= "http://localhost/img/ustaRestaurante/product/VinoCaliente.jpg",
                             Price=14000.0,
                             ProductTypeId=16
                            },
                        new Product()
                            {
                             Name= "Cuba Libre",
                             Description="Ron Boyacá y Coca-Cola",
                             Image= "http://localhost/img/ustaRestaurante/product/CubaLibre.jpg",
                             Price=18000.0,
                             ProductTypeId=16
                            },
                        new Product()
                            {
                             Name= "Mojito",
                             Description="Cóctel con soda, ron blanco, sumo de limón y hierbabuena",
                             Image= "http://localhost/img/ustaRestaurante/product/Mojito.jpg",
                             Price=22000.0,
                             ProductTypeId=16
                            },
                        new Product()
                            {
                             Name= "Caipiroska",
                             Description="Cóctel con soda, vodka y  sumo de limón",
                             Image= "http://localhost/img/ustaRestaurante/product/Capiroska.jpg",
                             Price=22000.0,
                             ProductTypeId=16
                            }


                    });
                    context.SaveChanges();
                }

                //Delivery
                if (!context.Deliveries.Any())
                {
                    context.Deliveries.AddRange(new List<Delivery>()
                    {
                        new Delivery()
                        {
                            NameDelivery="Antonio Cuevas Villa",
                            Phone="3112215106",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Joaquín García González",
                            Phone="3110717311",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Miguel Ángel Jiménez Miranda",
                            Phone="3122538875",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Raúl Álvarez Jareño",
                            Phone="3128146320",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Javier Plaza Fernández",
                            Phone="3162613822",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="José Manuel Torres López",
                            Phone="3115487872",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Ramón De Castro Gómez",
                            Phone="3132271435",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Miguel Flores Díaz",
                            Phone="3130623171",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="María Ayuso Hernández",
                            Phone="3168011616",
                            StateDelivery=true
                        },
                         new Delivery()
                        {
                            NameDelivery="Juan Antonio Sanz Bañon",
                            Phone="3115482113",
                            StateDelivery=true
                        }
                    });
                    context.SaveChanges();
                }
                //Cart
                if (!context.Carts.Any())
                {
                    context.Carts.AddRange(new List<Cart>()
                    {
                        new Cart()
                        {
                            ProductId= 15,
                        },
                        new Cart()
                        {
                            ProductId= 26,
                        },
                        new Cart()
                        {
                            ProductId= 17,
                        },
                        new Cart()
                        {
                            ProductId= 36,
                        },

                 });
                    context.SaveChanges();
                }
                //Comment
                if (!context.Comments.Any())
                {
                    context.Comments.AddRange(new List<Comment>()
                    {
                        new Comment()
                        {
                            TitleComment="Deliciosos",
                            qualification=Enum.QualityProduct.Excelente,
                            Opinion="",
                            ProductId=5
                        },
                        new Comment()
                        {
                            TitleComment="Mi plato favorito",
                            qualification=Enum.QualityProduct.Excelente,
                            Opinion="Excelente emplatado con los mejores sabores de la comida Italinana 🤌",
                            ProductId=12
                        },
                        new Comment()
                        {
                            TitleComment="Excelente",
                            qualification=Enum.QualityProduct.Excelente,
                            Opinion="Mama mia",
                            ProductId=19
                        },
                        new Comment()
                        {
                            TitleComment="Delicioso",
                            qualification=Enum.QualityProduct.Bueno,
                            Opinion="Es un buen plato, pero el restaurante cuenta con mejores",
                            ProductId=12
                        },
                        new Comment()
                        {
                            TitleComment="Recomendadisimooooo!",
                            qualification=Enum.QualityProduct.Excelente,
                            Opinion="La mejor Comida Italiana en Sogamoso🤌",
                            ProductId=25
                        },
                        new Comment()
                        {
                            TitleComment="Para chuparse los dedos",
                            qualification=Enum.QualityProduct.Excelente,
                            Opinion="Es de mis comidas favoritas en toda la ciudad 🤌",
                            ProductId=29
                        }
                    });
                    context.SaveChanges();
                }
                //Order
                if (!context.Orders.Any())
                {
                    context.Orders.AddRange(new List<Order>()
                    {
                        new Order()
                        {
                            Email="juan.roblesa@usantoto.edu.co",
                            DeliveryAddreess="calle 28 A # 7A-10"
                        },
                        new Order()
                        {
                           Email="luis.chaparroh@usantoto.edu.co",
                            DeliveryAddreess="calle 28 A # 7A-10"
                        }

                 });
                    context.SaveChanges();
                }
                //Ticket
                if (!context.Tickets.Any())
                {
                    context.Tickets.AddRange(new List<Ticket>()
                    {
                        new Ticket()
                        {
                            NumberTicket="1",
                            Date=DateTime.Now.AddDays(-30),
                            DeliveryId=1
                        },
                        new Ticket()
                        {
                            NumberTicket="2",
                            Date=DateTime.Now.AddDays(-30),
                            DeliveryId=2
                        },

                 });
                    context.SaveChanges();
                }
                //OrderDetail
                if (!context.OrderDetails.Any())
                {
                    context.OrderDetails.AddRange(new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                             Total=18000.0,
                             Amount=1,
                             OrderId=1,
                             ProductId=14,
                             TicketId=1
                        },
                        new OrderDetail()
                        {
                             Total=25000.0,
                             Amount=1,
                             OrderId=1,
                             ProductId=13,
                             TicketId=1
                        },
                        new OrderDetail()
                        {
                             Total=18000.0,
                             Amount=1,
                             OrderId=1,
                             ProductId=15,
                             TicketId=1
                        },
                        new OrderDetail()
                        {
                             Total=18000.0,
                             Amount=1,
                             OrderId=1,
                             ProductId=26,
                             TicketId=1
                        },
                        new OrderDetail()
                        {
                             Total=18000.0,
                             Amount=1,
                             OrderId=2,
                             ProductId=14,
                             TicketId=2
                        },
                        new OrderDetail()
                        {
                             Total=18000.0,
                             Amount=1,
                             OrderId=2,
                             ProductId=15,
                             TicketId=2
                        },
                        new OrderDetail()
                        {
                             Total=32000.0,
                             Amount=1,
                             OrderId=2,
                             ProductId=32,
                             TicketId=2
                        },

                 });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUserAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                //ROLES
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                if (await roleManager.FindByNameAsync(UserRoles.Admin) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (await roleManager.FindByNameAsync(UserRoles.User) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }
                //USERS
                string password = "Ust4.T1ck3ts";
                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                string email = "luis.chaparroh@usantoto.edu.co";
                if (await userManager.FindByNameAsync(email) == null)
                {
                    var user = new IdentityUser()
                    {
                        UserName = email,
                        Email = email,
                        PhoneNumber = "3143385561",
                        EmailConfirmed = true,
                    };
                    var result = await userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        await userManager.AddPasswordAsync(user, password);
                        await userManager.AddToRoleAsync(user, UserRoles.Admin);
                    }
                }


                email = "juan.roblesa@usantoto.edu.co";
                if (await userManager.FindByNameAsync(email) == null)
                {
                    var user = new IdentityUser()
                    {
                        UserName = email,
                        Email = email,
                        PhoneNumber = "3138342018",
                        EmailConfirmed = true,
                    };
                    var result = await userManager.CreateAsync(user);
                    if (result.Succeeded)
                    {
                        await userManager.AddPasswordAsync(user, password);
                        await userManager.AddToRoleAsync(user, UserRoles.User);
                    }
                }

            }
        }

    }
}
