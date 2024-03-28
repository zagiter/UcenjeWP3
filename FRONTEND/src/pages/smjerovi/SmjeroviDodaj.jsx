
import { Button, Col, Container, Form, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import { RoutesNames } from "../../constants";

export default function SmjeroviDodaj(){

    function obradiSubmit(e){   // e predstavlja event
        e.preventDefault();
        alert('Dodajem smjer');

    }
    
    return (

        <Container>
            <Form onSubmit={obradiSubmit}>
        
            <Row>
                <Col sm={12} md={3} lg={6}>
                    <Link className="btn btn-danger siroko" to={RoutesNames.SMJER_PREGLED}>
                        Odustani
                    </Link>
                 </Col>
                 <Col sm={12} md={9} lg={6}>
                    <Button className="siroko" variant="primary" type="submit">
                        Dodaj
                    </Button>
                 
                 </Col>
            
            </Row>
        
            </Form>
        
        </Container>
    );
}