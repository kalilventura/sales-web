import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-seller',
  templateUrl: './list-seller.component.html',
  styleUrls: ['./list-seller.component.css']
})
export class ListSellerComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  createSeller() {
    this.router.navigate(['/seller/create']);
  }
}
