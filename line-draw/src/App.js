import React from 'react';
import './App.css';

import {
    Navbar,
    Nav,
    NavDropdown,
    Container,
} from 'react-bootstrap';

class File extends React.Component {


    render() {
        return (
            <NavDropdown title="File">
                <NavDropdown.Item className="d-flex">
                    Save&emsp;
                    <span className="badge badge-light ml-auto my-auto">ctrl + s</span>
                </NavDropdown.Item>
                <NavDropdown.Item className="d-flex">
                    Save As&emsp;
                    <span className="badge badge-light ml-auto">ctrl + shift + s</span>
                </NavDropdown.Item>
                <NavDropdown.Item className="d-flex">
                    Save All&emsp;
                    <span className="badge badge-light ml-auto">ctrl + k s</span>
                </NavDropdown.Item>
                <NavDropdown.Item className="d-flex">
                    Open&emsp;
                    <span className="badge badge-light ml-auto">ctrl + o</span>
                </NavDropdown.Item>
            </NavDropdown>
        )
    }
}

class Edit extends React.Component {

    render() {
        return (
            <NavDropdown title="Edit">
                <NavDropdown.Item>Action</NavDropdown.Item>
                <NavDropdown.Item>Another action</NavDropdown.Item>
                <NavDropdown.Item>Something</NavDropdown.Item>
            </NavDropdown>
        )
    }
}

class Tools extends React.Component {

    render() {
        return (
            <NavDropdown title="Tools">
                <NavDropdown.Item>Action</NavDropdown.Item>
                <NavDropdown.Item>Another action</NavDropdown.Item>
                <NavDropdown.Item>Something</NavDropdown.Item>
            </NavDropdown>
        )
    }
}

function App() {
    return (
        <>
            <header>
                <Navbar bg="light" expand="sm">
                    <Navbar.Brand href="#home">&nbsp;LD</Navbar.Brand>
                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                        <Nav className="mr-auto rounded-0">
                            <File />
                            <Edit />
                            <Tools />
                        </Nav>
                    </Navbar.Collapse>
                </Navbar>
            </header>
            <main>
                <Container fluid>
                    <div className="mt-3"></div>
                    <ul className="nav nav-tabs border-0">
                        <li className="nav-item">
                            <span className="nav-link active rounded-0" type="button">Test</span>
                        </li>
                        <li className="nav-item">
                            <span className="nav-link rounded-0" type="button">+</span>
                        </li>
                    </ul>
                    <div className="row">
                        <div className="col">
                            <div className="row h-100">
                                <div className="col-md h-100 pr-0">
                                    <textarea className="form-control h-100 rounded-0 rounded-bottom"></textarea>
                                </div>
                                <div className="col-3 h-100">
                                    <div className="card border-0 bg-light h-100 rounded-0">
                                        <div className="card-body">
                                            <h6 className="card-title">Frames —</h6>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="col-3 bg-light">
                            <div className="card bg-transparent rounded-0">
                                <div className="card-body">
                                    <h6 className="card-title">Object —</h6>
                                    Name
                                    <input className="form-control rounded-0" type="text" />
                                    Default Animation
                                    <select className="form-control rounded-0">
                                        <option>Test</option>
                                    </select>
                                </div>
                            </div>
                            <div className="mt-3"></div>
                            <div className="card bg-transparent rounded-0">
                                <div className="card-body">
                                    <h6 className="card-title">Animation —</h6>
                                    Name
                                    <input className="form-control rounded-0" type="text" value="Test" />
                                    Speed
                                    <input className="form-control rounded-0" type="number" />
                                    Preview
                                    <div className="card rounded-0">
                                        <div className="card-body">

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </Container>
            </main>
        </>
    );
}

export default App;
