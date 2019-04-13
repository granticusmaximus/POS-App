import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';
import '../../assets/css/App.css';

export class Login extends Component {
    static displayName = Login.name;
  render () {
    return (
      <div>
        <br />
        <center>
          <div className="loginBox">
            <div className="loginHeader">Login</div>
            <Form>
        <FormGroup>
          <Label for="exampleEmail">User ID:</Label>
          <Input type="email" name="email" id="exampleEmail" placeholder="Put User ID" />
        </FormGroup>
        <FormGroup>
          <Label for="examplePassword">PIN:</Label>
          <Input type="password" name="password" id="examplePassword" placeholder="Put in PIN" />
        </FormGroup>
        <Button color="success">Login</Button>
      </Form>
          </div>
        </center>
      </div>
      
    );
  }
}