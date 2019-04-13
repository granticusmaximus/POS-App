import React, { Component } from 'react';
import { Button } from 'reactstrap';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <center>
        <h1>POS</h1>
        <h4>Please Login</h4>
        </center>
      </div>
    );
  }
}
