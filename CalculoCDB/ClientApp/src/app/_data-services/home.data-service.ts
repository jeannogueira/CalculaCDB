import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class HomeDataService {

  url: string = '';

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;

  }

  post(data: any): Observable<any> {
    debugger;
    return this.http.post(`${this.url}calculos`, data);
  }


}
