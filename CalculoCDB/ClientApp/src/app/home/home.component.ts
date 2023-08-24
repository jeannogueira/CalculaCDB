import { Component, Inject, OnInit } from '@angular/core';
import { HomeDataService } from '../_data-services/home.data-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  calculo: any = {};
  resultado: any = {};

  constructor(private homeDataService: HomeDataService) { }

  ngOnInit() {
    // TODO document why this method 'ngOnInit' is empty

  }

  calcular() {
    debugger;
    if (this.calculo.valorInicial <= 0 || this.calculo.valorInicial == undefined) {
      alert('O valor deve ser maior que zero');
    }
    else if (this.calculo.prazo <= 1 || this.calculo.prazo == undefined) {
      alert('O prazo deve ser maior que 1 mês');
    }
    else {
      this.homeDataService.post(this.calculo).subscribe(data => {
        if (data) {
          alert('Calculo realizado com sucesso!');
          this.resultado = data;
        } else {
          alert('Por favor, realizar o preenchimento de todos os campos!');
        }
      }, error => {
        console.log(error);
        alert('erro interno do sistema');
      })
    }
  }

}

