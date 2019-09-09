var app = new Vue({
    el: '#app',
    data: {
        nombreFiltro: '',
        nombreFiltroMin: '',
        categories: [],
        categoryIdFilter:'Todos',
        listaCanales: [],
        listaCanalesPlus: [],
        listaCanalesTotal: [],
        listaCanalesTotalSinFiltrar: [],

    },
    methods: {
        GetCategoriesFromServer: function () {
            $.get('/api/canalesManagement/GetAllGenero')
                .then(categoryArray => {
                    this.categories.push(...categoryArray);
                });
        },
        cambioElFiltro: function () {
            if (this.categoryIdFilter == 'Todos') {
                this.listaCanalesTotal = [];
                this.listaCanalesTotalSinFiltrar = [];
                this.GetCanalesTotalFromServer();
            }
            else {
                $.get('/api/canalesManagement/GetCanalesByCategory?category=' + this.categoryIdFilter)
                    .then(productosDelServidor => {
                        this.listaCanalesTotal = [];
                        this.listaCanalesTotalSinFiltrar = [];
                        this.listaCanalesTotal.push(...productosDelServidor)
                        this.listaCanalesTotalSinFiltrar.push(...productosDelServidor)
                    });
            }
        },
        GetCanalesFromServer: function () {
            $.get('/api/canalesManagement/GetAllCanales')
                .then(canalesArray => {
                    this.listaCanales.push(...canalesArray);
                });
        },
        GetCanalesPlusFromServer: function () {
            $.get('/api/canalesManagement/GetAllCanalesPlus')
                .then(canalesPlusArray => {
                    this.listaCanalesPlus.push(...canalesPlusArray);
                });
        },
        GetCanalesTotalFromServer: function () {
            $.get('/api/canalesManagement/GetAllCanalesTotal')
                .then(canalesTotalArray => {
                    this.listaCanalesTotal.push(...canalesTotalArray);
                    this.listaCanalesTotalSinFiltrar.push(...canalesTotalArray);
                });
        },

        ActivarFiltro: function () {
            if (this.nombreFiltro.length > 0) {
                this.nombreFiltroMin = this.nombreFiltro.toLowerCase();
                this.listaCanalesTotal = [];
                this.listaCanalesTotal = this.listaCanalesTotalSinFiltrar.filter(x => {
                    return x.nombreCanal.includes(this.nombreFiltroMin);
                });
            }
            else {
                this.listaCanalesTotal = this.listaCanalesTotalSinFiltrar;
            }
        }
    }
})
app.GetCanalesTotalFromServer();
app.GetCategoriesFromServer();
app.GetCanalesFromServer();
app.GetCanalesPlusFromServer();


