
import { Button, Col, Container, Form, FormGroup, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RoutesNames } from "../../constants";
import SmjerService from "../../services/SmjerService";

export default function SmjeroviDodaj(){
    const navigate = useNavigate();

    async function dodaj(smjer){
        const odgovor = await SmjerService.post(smjer);
        if (odgovor.greska){
            console.log(odgovor.poruka)
            alert('Pogledaj konzolu');
            return;
        }
        navigate(RoutesNames.SMJER_PREGLED);
    }

    function obradiSubmit(e){   // e predstavlja event
        e.preventDefault();
        //alert('Dodajem smjer');

        const podaci = new FormData(e.target);

        const smjer = {

            naziv: podaci.get('naziv'),  // 'naziv' je name atribut u Form.Control
            trajanje: parseInt(podaci.get('trajanje')), // na backend je int
            cijena: parseFloat(podaci.get('cijena')),
            verificiran: podaci.get('verificiran')=='on' ? true : false
            
        };

        //console.log(smjer);
        dodaj(smjer);

    }
    
    return (

        <Container>
            <Form onSubmit={obradiSubmit}>
                
                <FormGroup controlId="naziv">
                    <Form.Label>Naziv</Form.Label>
                    <Form.Control type="text" name="naziv" />
                </FormGroup>

                <FormGroup controlId="naziv">
                    <Form.Label>Trajanje</Form.Label>
                    <Form.Control type="text" name="trajanje" />
                </FormGroup>

                <FormGroup controlId="naziv">
                    <Form.Label>Cijena</Form.Label>
                    <Form.Control type="text" name="cijena" />
                </FormGroup>

                <FormGroup controlId="verificiran"> 
                    <Form.Check label="Verificiran" name="verificiran" />
                </FormGroup>
                
                
                
                <hr />
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