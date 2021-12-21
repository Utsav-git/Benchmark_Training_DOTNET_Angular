import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-person-display',
  templateUrl: './person-display.component.html',
  styleUrls: ['./person-display.component.css']
})
export class PersonDisplayComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  person: any[] = [{
    id: 1,
    name: "Utsav",
    city: "Kolhapur"
  },
  ];

}
