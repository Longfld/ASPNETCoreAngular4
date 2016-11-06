import { Component, OnInit } from '@angular/core';

import { StaffService } from '../shared/staff.service';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html'
})
export class HomeComponent implements OnInit {
    characters: string[];

    constructor(private staffService: StaffService) { }

    ngOnInit() {
        this.staffService.getStaff()
            .subscribe(characters => this.characters = characters);
    }
}
