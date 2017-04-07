import { Component } from '@angular/core';
import { ProductService } from './counter.service';
import { IProduct } from './product';
@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0;
    products: IProduct[];
    errorMessage: string;

    constructor(private _productService: ProductService) {

    }

    public incrementCounter() {
        this.currentCount++;

        this._productService.getProducts()
            .subscribe(products => this.products = products,
            error => this.errorMessage = <any>error);
    }
}
