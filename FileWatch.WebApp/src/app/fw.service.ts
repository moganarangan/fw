import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FwService {

  constructor(private http: HttpClient) { }

  getfiles = (): Observable<any> => {
    const apiURL = 'https://localhost:44375/api/files';

    return this.http.get<any>(apiURL);
  }
}
