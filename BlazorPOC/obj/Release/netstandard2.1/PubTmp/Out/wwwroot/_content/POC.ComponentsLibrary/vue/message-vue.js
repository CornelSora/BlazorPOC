(function () {
    vueMethods = {
            vueInstance: {},
            init: function () {
                this.vueInstance = new Vue({
                    el: '#sg1',
                    // define data - initial display text
                    data: {
                        m1: "This is a hello world with vue"
                    },
                    methods: {
                        incrementText(value) {
                            this.m1 += value
                        }
                    }
                })
            }
        }
})();