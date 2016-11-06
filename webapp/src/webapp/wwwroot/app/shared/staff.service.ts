import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class StaffService {
    
    constructor(private http: Http) { }

    getCharacters() {
        return this.http.get('api/Staff/GetStaff')
            .map(response => response.json());
    }
}
