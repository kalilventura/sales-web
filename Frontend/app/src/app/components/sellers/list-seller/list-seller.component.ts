import { SellersService } from './../../../core/services/sellers/sellers.service';
import { Seller } from './../../../core/models/seller';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list-seller',
  templateUrl: './list-seller.component.html',
  styleUrls: ['./list-seller.component.css']
})
export class ListSellerComponent implements OnInit {

  sellers: Seller[];
  constructor(private router: Router, private service: SellersService) { }

  ngOnInit(): void {
    this.listSellers(1, 5);
  }

  listSellers(currenPage: number, pageSize: number) {
    this.service.getAllSellers(currenPage, pageSize).subscribe(response => {
      this.sellers = response.data.results;
    })
  }

  createSeller() {
    this.router.navigate(['/seller/create']);
  }
}
